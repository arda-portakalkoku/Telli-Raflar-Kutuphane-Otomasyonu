using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class Romanlar:zKitaplar
    {
        public string tur;
        public string orijinaldil;
        public string basımyili;
        
        public Romanlar(string kitapadi, string yazar, string yayinNo, int sayfasayisi, string yayınevi, bool mevcutMu, string tur, string orijinaldil, string basımyili)
            : base(kitapadi, yazar, yayinNo, sayfasayisi, yayınevi, mevcutMu)
        {
            this.tur = tur;
            this.orijinaldil = orijinaldil;
            this.basımyili = basımyili;
        }

        public override void KitapBilgileriGoster()
        {
            Console.WriteLine("Roman Bilgileri:");
            Console.WriteLine("Kitap Adı: " + base.kitapadi);
            Console.WriteLine("Yazar: " + base.yazar);
            Console.WriteLine("Tür: " + tur);
            Console.WriteLine("Orijinal Dil: " + orijinaldil);
            Console.WriteLine("Yayınevi: " + base.yayınevi);
            Console.WriteLine("Sayfa Sayısı: " + base.sayfasayisi);
            Console.WriteLine("Yayın Numarası: " + base.yayinNo);
            Console.WriteLine("Basımyılı: " + basımyili);
           

        }
    }
}
