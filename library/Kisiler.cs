
namespace kutuphane_otomasyon
{
    internal class Kisiler
    {
        public string isim;
        public string soyisim;
        public int dogumyili;
        

        public Kisiler(string isim, string soyisim, int dogumyili)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.dogumyili = dogumyili;


            

        }
        public List<string> OduncKitaplar = new List<string>();
        public virtual void KisiBilgileri()
        {
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.WriteLine(dogumyili);
            

        }

    }
}