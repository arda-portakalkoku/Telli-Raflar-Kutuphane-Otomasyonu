using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class dergi: zKitaplar
    {
        
        public int sayino;
        public int yil;
        


        public dergi(string kitapadi, string yazar, string yayinNo, int sayfasayisi, string yayınevi, bool mevcutMu, string editor, int sayino, int yil)
            : base(kitapadi, yazar, yayinNo)
        {
            
            this.sayino = sayino;
            this.yil = yil; 
            
        }
        public dergi(string kitapadi, string yazar, string yayinNo)//dergi bağışı
            : base(kitapadi, yazar, yayinNo)
        {
            this.sayino = sayino;
            this.yil = yil;
        }

        public dergi(string kitapadi, string yazar, string yayinNo, int sayino, int yil) : this(kitapadi, yazar, yayinNo)
        {
        }

        public override void KitapBilgileriGoster()
        {
            Console.WriteLine("Dergi Bilgileri:");
            Console.WriteLine("Dergi Adı: " + base.kitapadi);
            Console.WriteLine("Yazar: " + base.yazar);
            Console.WriteLine("Sayı No: " + sayino);
            Console.WriteLine("ISBN: " + base.yayinNo);
            Console.WriteLine("Yıl: " + yil);
            
        }
    }
}
