using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class GumusUye:uyelikler
    {
        public GumusUye(string isim, string soyisim, int dogumyili,  string uyeliktipi, double bakiye, int uyelikucreti, string oduncalinankitaplar)
            :base(isim, soyisim, dogumyili,  uyeliktipi, bakiye, uyelikucreti, oduncalinankitaplar)
        {

        }

        public GumusUye()
            : base("", "", 0, "", 0, 0, "")
        {
        }

        public override int kitapkiralama()
        {
            return 3;
        }
        public override int oduncsuresi()
        {
            return 10;  
        }

        public override int uyelikucretia()
        {
            return 50; 
        }

        public override void Bilgilerigoster()
        {
            base.KisiBilgileri();
            base.Bilgilerigoster();
            kitapkiralama();
            oduncsuresi();
            uyelikucretia();
        }
       
    }
}
