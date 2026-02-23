using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class AltinUye : uyelikler
    {
        public AltinUye(string isim, string soyisim, int dogumyili,  string uyeliktipi, double bakiye, int uyelikucreti, string oduncalinankitaplar)
           : base(isim, soyisim, dogumyili,  uyeliktipi, bakiye, uyelikucreti, oduncalinankitaplar)
        {

        }

        public AltinUye()
            : base("", "", 0, "", 0, 0, "")
        {
        }

        public override int kitapkiralama()
        {
            return 5;
        }
        public override int oduncsuresi() 
        {
            return 20;
        }
        public override int uyelikucretia()
        {
            if (base.dogumyili >=2000)
            {
                return 50;
            }
            else
            {
                return 100;
            }
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