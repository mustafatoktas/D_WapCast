import argparse
import os
from pathlib import Path
from PIL import Image, ImageDraw, ImageFont
import sys

def parse_args():
    p = argparse.ArgumentParser(description="Deneme davetiyesi oluştur")
    p.add_argument(
        '--template', required=True,
        help='Şablon resim yolu (.jpg/.png)'
    )
    p.add_argument(
        '--text', help='Resim üzerine yazılacak metin (örn: "Merhaba Örnek İsim")'
    )
    p.add_argument(
        '--size', type=int,
        help='Font boyutu (text ile birlikte kullanılacak)'
    )
    p.add_argument(
        '--x', type=int,
        help='Text’in X koordinatı'
    )
    p.add_argument(
        '--y', type=int,
        help='Text’in Y koordinatı'
    )
    p.add_argument(
        '--font', help='TTF/OTF font dosyası yolu (yoksa Arial fallback)'
    )
    return p.parse_args()

def main():
    args = parse_args()

    # şablonu aç
    if not os.path.isfile(args.template):
        print(f"Hata: Şablon bulunamadı: {args.template}", file=sys.stderr)
        sys.exit(1)
    img = Image.open(args.template).convert('RGB')
    draw = ImageDraw.Draw(img)

    # eğer text parametresi geldiyse çiz
    if args.text is not None:
        # Koordinat ve boyut kontrolleri
        for name in ("size", "x", "y"):
            if getattr(args, name) is None:
                print(f"Hata: --text ile birlikte --{name} de gerekli.", file=sys.stderr)
                sys.exit(1)

        # font yolu: kullanıcı vermediyse Window'un Arial'ini kullan
        if args.font and os.path.isfile(args.font):
            font_path = args.font
        else:
            windir = os.environ.get("WINDIR", r"C:\Windows")
            font_path = os.path.join(windir, "Fonts", "arial.ttf")
            if not os.path.isfile(font_path):
                print(f"Uyarı: Arial bulunamadı, varsayılan sisteme göre devam ediliyor.", file=sys.stderr)

        font = ImageFont.truetype(font_path, args.size)
        draw.text((args.x, args.y), args.text, fill='black', font=font)

    # masaüstüne kaydet
    desktop = Path.home() / "Desktop"
    out_path = desktop / "deneme_davetiye.jpg"
    img.save(out_path)

if __name__ == '__main__':
    main()
