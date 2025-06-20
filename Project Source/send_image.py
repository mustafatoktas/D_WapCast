import argparse
import sys
import time
import tempfile
from pathlib import Path
import pandas as pd
import pywhatkit
from PIL import Image, ImageDraw, ImageFont

# flush ile anlık çıktı için fonksiyon
def out(*args, **kwargs):
    print(*args, **{**kwargs, 'flush': True})

# argümanları al
def parse_args():
    parser = argparse.ArgumentParser(description="Toplu WhatsApp resimli mesaj gönder")
    parser.add_argument('-e', '--excel',    required=True, help='Excel dosyası (.xlsx/.xls)')
    parser.add_argument('-t', '--template', required=True, help='Şablon resim dosyası')
    parser.add_argument('-m', '--message',  required=True, help='Mesaj şablonu (içinde {name} kullanılabilir)')
    parser.add_argument('-w', '--wait',     type=int, required=True, help='Bekleme süresi (saniye)')
    parser.add_argument('--text', help='Resim üzerine yazılacak şablon (örn: "Merhaba {name}")')
    parser.add_argument('--size', type=int, help='Font büyüklüğü')
    parser.add_argument('--x',    type=int, help='X koordinatı')
    parser.add_argument('--y',    type=int, help='Y koordinatı')
    parser.add_argument('--font', help='TTF font yolu')
    return parser.parse_args()

# ana işlev
def main():
    args = parse_args()

    # excel oku
    try:
        df = pd.read_excel(args.excel)
    except Exception as ex:
        out(f"Hata: Excel okunamadı: {ex}", file=sys.stderr)
        sys.exit(1)

    # kolon kontrolü
    if not {'İsim Soyisim', 'Numara'}.issubset(df.columns):
        out("Hata: Excel'de 'İsim Soyisim' ve 'Numara' kolonları bulunmalı!", file=sys.stderr)
        sys.exit(1)

    total = len(df)
    out(f"Toplam kayıt: {total}")

    # döngüyle gönder
    for idx, row in df.iterrows():
        name = row['İsim Soyisim']
        num  = str(row['Numara']).strip()
        no   = idx + 1

        # numara validasyonu
        if not (num.isdigit() and len(num) >= 10):
            out(f"{no}/{total} — {name}: geçersiz numara ({num})")
            continue

        # şablon resmi aç
        try:
            img = Image.open(args.template).convert('RGB')
        except Exception as ex:
            out(f"Hata: Şablon açılamadı: {ex}", file=sys.stderr)
            sys.exit(1)

        # opsiyonel metin
        if args.text:
            if None in (args.size, args.x, args.y):
                out("Hata: --text ile birlikte --size, --x ve --y argümanları da verilmeli.", file=sys.stderr)
                sys.exit(1)

            font_path = args.font if args.font and Path(args.font).is_file() else Path("C:/Windows/Fonts/arial.ttf")
            font = ImageFont.truetype(str(font_path), args.size)
            draw = ImageDraw.Draw(img)
            draw.text((args.x, args.y), args.text.format(name=name), fill='black', font=font)

        # geçici dosyaya kaydet
        tmp = tempfile.NamedTemporaryFile(suffix=".jpg", delete=False)
        img.save(tmp.name)
        tmp.close()

        out(f"{no}/{total} — {name} ({num}) gönderiliyor…")
        try:
            pywhatkit.sendwhats_image(
                f"+90{num}",
                tmp.name,
                args.message.format(name=name),
                wait_time=args.wait,
                tab_close=True,
                close_time=5
            )
            time.sleep(5)
        except Exception as ex:
            out(f"{name} gönderilemedi: {ex}", file=sys.stderr)

        # geçici dosyayı sil
        try:
            Path(tmp.name).unlink()
        except:
            pass

    out("Tüm resimli gönderimler tamamlandı.")

if __name__ == '__main__':
    main()