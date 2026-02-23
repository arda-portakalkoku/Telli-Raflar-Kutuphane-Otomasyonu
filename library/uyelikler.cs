using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class uyelikler:Kisiler
    {
        public string uyeliktipi;
        public int bakiye;
        public int uyelikucreti; 
        public string oduncalinankitaplar;
        

        public uyelikler(string isim, string soyisim,int dogumyili,  string uyeliktipi, int bakiye, int uyelikucreti, string oduncalinankitaplar)
            :base(isim, soyisim, dogumyili)
        {
            this.uyeliktipi = uyeliktipi;
            this.bakiye = bakiye;
            this.uyelikucreti = this.uyelikucretia();
            this.oduncalinankitaplar = oduncalinankitaplar;
        }

        public uyelikler(string isim, string soyisim, int dogumyili, string uyeliktipi, double bakiye1, int uyelikucreti, string oduncalinankitaplar) : base(isim, soyisim, dogumyili)
        {
            this.uyeliktipi = uyeliktipi;
            this.uyelikucreti = uyelikucreti;
            this.oduncalinankitaplar = oduncalinankitaplar;
        }

        public virtual int kitapkiralama()
        {
            return 0;
        }

        public virtual int oduncsuresi()
        {
            return 0;
        }
        public virtual int uyelikucretia()
        {
            return 0;
        }

        public virtual void Bilgilerigoster()
        {
            Console.WriteLine(uyeliktipi);
            Console.WriteLine(bakiye);
            Console.WriteLine(uyelikucreti);
            Console.WriteLine(oduncalinankitaplar);
        }
    }
    
}