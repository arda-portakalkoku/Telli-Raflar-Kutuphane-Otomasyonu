using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   kutuphane_otomasyon
{
    internal class zKitaplar
    {
        public string kitapadi;
        public string yazar;
        public string yayinNo;
        public int sayfasayisi;
        public string yayınevi;
        public bool mevcutMu;

        public zKitaplar(string kitapadi, string yazar, string yayinNo, int sayfasayisi, string yayınevi, bool mevcutMu)
        {
            this.kitapadi = kitapadi;
            this.yazar = yazar;
            this.yayinNo = yayinNo;
            this.sayfasayisi = sayfasayisi;
            this.yayınevi = yayınevi;
            this.mevcutMu = true;
        }
        public zKitaplar(string kitapadi,string yazar, string yayinNo)//dergi bağışı
        {
            this.kitapadi = kitapadi;
            this.yazar = yazar;
            this.yayinNo = yayinNo;
        }



        public virtual void KitapBilgileriGoster()
        {
            Console.WriteLine("Kitap Adı: " + kitapadi);
            Console.WriteLine("Yazar: " + yazar);
            Console.WriteLine("Yayın Numarası: " + yayinNo);
            Console.WriteLine("Sayfa Sayısı: " + sayfasayisi);
            Console.WriteLine("Yayınevi: " + yayınevi);
            Console.WriteLine("Mevcut Mu: " + (mevcutMu ? "Evet" : "Hayır"));
        }
    }
}
