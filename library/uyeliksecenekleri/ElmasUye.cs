using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_otomasyon
{
    internal class ElmasUye:uyelikler
    {
        public ElmasUye(string isim, string soyisim, int dogumyili,  string uyeliktipi, double bakiye, int uyelikucreti, string oduncalinankitaplar)
            :base(isim, soyisim, dogumyili,  uyeliktipi, bakiye, uyelikucreti, oduncalinankitaplar)
        {

        }

        public ElmasUye()
            : base("", "", 0, "", 0, 0, "")
        {

        }

        public override int kitapkiralama()
        {
            return 10;

        }
        public override int oduncsuresi()
        {
            
            return 30;
        }
        public override int uyelikucretia()
        {
            if (base.dogumyili >=2000)
            {
                
                return 150;
            }
            else
            {
                
                return 300;
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
