import argparse
import sys
import time
import pandas as pd
import pywhatkit

# flush ile anlık çıktı için fonk
def out(*args, **kwargs):
    print(*args, **{**kwargs, 'flush': True})

# argümanları al
def parse_args():
    parser = argparse.ArgumentParser(description="Toplu WhatsApp yazılı mesaj gönder")
    parser.add_argument('-e', '--excel', required=True, help='Excel dosyası (.xlsx/.xls)')
    parser.add_argument('-m', '--message', required=True, help='Mesaj şablonu (içinde {name} kullanılabilir)')
    parser.add_argument('-w', '--wait', type=int, required=True, help='Bekleme süresi (saniye)')
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

        message = args.message.format(name=name)
        out(f"{no}/{total} — {name} ({num}) gönderiliyor…")

        try:
            pywhatkit.sendwhatmsg_instantly(
                f"+90{num}",
                message,
                wait_time=args.wait,
                tab_close=True,
                close_time=5
            )
            time.sleep(5)
        except Exception as ex:
            out(f"{name} gönderilemedi: {ex}", file=sys.stderr)

    out("Tüm mesajlar gönderildi.")

if __name__ == '__main__':
    main()
