using kutuphane_otomasyon;
using System;
using System.Collections.Generic;


namespace kutuphane_otomasyon
{
    internal class interface_main
    {
        static void Main(string[] args)
        {
            int bakiye = 0;

            List<zKitaplar> kitaplars = new List<zKitaplar>();
            // İleride kullanılmak üzere tanımlanan listeler
            List<dergi> _dergi = new List<dergi>();
            List<uyelikler> uyeliklers = new List<uyelikler>();

            // Örnek Veri Girişleri
            kitaplars.Add(new Romanlar("Sefiller", "Victor Hugo", "ISBN-101", 1200, "Can Yayınları", true, "Klasik", "Fransızca", "1862"));
            kitaplars.Add(new Romanlar("Sherlock Holmes", "Sir Arthur Conan Doyle", "ISBN-102", 350, "Martı", true, "Polisiye", "İngilizce", "1887"));
            kitaplars.Add(new Romanlar("1984", "George Orwell", "ISBN-105", 352, "Can Yayınları", true, "Distopya", "Türkçe", "1949"));
            kitaplars.Add(new Romanlar("Yüzüklerin Efendisi", "J.R.R. Tolkien", "ISBN-106", 1024, "Metis", true, "Fantastik", "Türkçe", "1954"));
            kitaplars.Insert(0, new Romanlar("Dune", "Frank Herbert", "ISBN-001", 712, "İthaki", true, "Bilim Kurgu", "Türkçe", "1965"));
            kitaplars.Insert(1, new Romanlar("Dune Mesihi", "Frank Herbert", "ISBN-002", 300, "İthaki", true, "Bilim Kurgu", "Türkçe", "1969"));
            kitaplars.Insert(2, new Romanlar("Dune Çocukları", "Frank Herbert", "ISBN-003", 500, "İthaki", true, "Bilim Kurgu", "Türkçe", "1976"));

            Console.WriteLine("--- TELLİ RAFLAR KÜTÜPHANESİ ---");
            Console.WriteLine("----------------------------------");

            // Ana Program Döngüsü
            while (true)
            {
                Console.WriteLine($"\nMevcut bakiyeniz: {bakiye} TL");
                Console.WriteLine("1: Üyelik Oluştur");
                Console.WriteLine("2: Bakiye Yükle");
                Console.WriteLine("3: Kitapları Listele");
                Console.WriteLine("4: Kütüphanemize Bağış Yapın");
                Console.WriteLine("5: Kitap Ödünç Alın");
                Console.WriteLine("6: Üyelik Bilgilerini Göster");
                Console.WriteLine("7: Çıkış");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1-7): ");

                string secim = Console.ReadLine();

                // if-else cehennemi yerine switch-case kullanıldı
                switch (secim)
                {
                    case "1":
                        Console.Write("İsim: ");
                        string isim = Console.ReadLine();
                        Console.Write("Soyisim: ");
                        string soyisim = Console.ReadLine();

                        // try-catch yerine profesyonel veri doğrulama (TryParse)
                        Console.Write("Doğum Yılı: ");
                        if (!int.TryParse(Console.ReadLine(), out int dogumyili))
                        {
                            Console.WriteLine("HATA: Lütfen geçerli bir sayı giriniz. İşlem iptal edildi.");
                            break; // Switch'ten çıkar, menüyü tekrar yükler
                        }

                        Console.WriteLine("Abonesi olmak istediğiniz paketin numarasını giriniz.");
                        Console.WriteLine("1) Gümüş Üyelik\n2) Altın Üyelik\n3) Elmas Üyelik");
                        string secim2 = Console.ReadLine();

                        // Nesne yönelimli kurallara uygun nesne üzerinden erişim
                        if (secim2 == "1")
                        {
                            
                            GumusUye yeniUye = new GumusUye(isim, soyisim, dogumyili, "Belirtilmedi", 0.0, 0, "Gümüş Üye");
                            
                            if (bakiye >= yeniUye.uyelikucretia())
                            {
                                bakiye -= yeniUye.uyelikucretia();
                                uyeliklers.Add(yeniUye);
                                Console.WriteLine("Sistem: Gümüş Üyeliğiniz başarıyla oluşturuldu.");
                            }
                            else { Console.WriteLine("Sistem: Yetersiz bakiye."); }
                        }

                        else if (secim2 == "2")
                        {
                            // 1. ADIM: Fabrikanın (Class) istediği tam 7 argümanı sırasıyla veriyoruz.
                            AltinUye yeniUye = new AltinUye(isim, soyisim, dogumyili, "Belirtilmedi", 0.0, 0, "Altın Üye");

                            // 2. ADIM: Ödeme ve Kayıt İşlemleri (Eski karmaşık yapıdan kurtulduk)
                            if (bakiye >= yeniUye.uyelikucretia())
                            {
                                bakiye -= yeniUye.uyelikucretia(); // Ücreti kestik
                                uyeliklers.Add(yeniUye); // Üyeyi kalıcı listeye ekledik
                                Console.WriteLine("Sistem: Altın Üyeliğiniz başarıyla oluşturuldu.");
                            }
                            else
                            {
                                Console.WriteLine("Sistem: Yetersiz bakiye.");
                            }
                        }
                        else if (secim2 == "3")
                        {
                            ElmasUye yeniUye = new ElmasUye(isim, soyisim, dogumyili, "Belirtilmedi", 0.0, 0, "Elmas Üye");
                            if (bakiye >= yeniUye.uyelikucretia())
                            {
                                bakiye -= yeniUye.uyelikucretia();
                                uyeliklers.Add(yeniUye);
                                Console.WriteLine("Sistem: Elmas Üyeliğiniz başarıyla oluşturuldu.");
                            }
                            else { Console.WriteLine("Sistem: Yetersiz bakiye."); }
                        }
                        else
                        {
                            Console.WriteLine("Sistem: Hatalı paket seçimi yaptınız.");
                        }
                        break;

                    case "2":
                        Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                        if (int.TryParse(Console.ReadLine(), out int tutar))
                        {
                            bakiye += tutar; // Hatalı olan "tutar += bakiye" düzeltildi
                            Console.WriteLine($"İşlem başarılı. Yeni bakiyeniz: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("HATA: Lütfen sadece sayısal bir tutar giriniz.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\n--- Kütüphanemizde Bulunan Kitaplar ---");
                        foreach (var kitap in kitaplars)
                        {
                            kitap.KitapBilgileriGoster();
                            Console.WriteLine("---------------------------");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Bağış yapmak istediğiniz kitabın/derginin bilgilerini giriniz.");
                        Console.Write("Tür Giriniz (Dergi / Kitap): ");
                        string tur1 = Console.ReadLine().ToLower();

                        if (tur1 == "dergi")
                        {
                            Console.Write("Dergi Adı: ");
                            string kitapadi = Console.ReadLine();
                            Console.Write("Yazar: ");
                            string yazar = Console.ReadLine();
                            Console.Write("Yayın Numarası (ISBN): ");
                            string yayinNo = Console.ReadLine();

                            Console.Write("Sayı No: ");
                            int sayino = int.TryParse(Console.ReadLine(), out int sNo) ? sNo : 0;

                            Console.Write("Yıl: ");
                            int yil = int.TryParse(Console.ReadLine(), out int y) ? y : 0;

                            zKitaplar dergi_bagis = new dergi(kitapadi, yazar, yayinNo, sayino, yil);
                            // TODO: İleride bu nesneyi ilgili listeye ekleyecek kod buraya gelecek

                            Console.WriteLine("Bağışınız sisteme kaydedildi. Teşekkür ederiz!");
                        }
                        else if (tur1 == "kitap" || tur1 == "okuma kitabı")
                        {
                            Console.Write("Kitap Adı: ");
                            string kitapadi = Console.ReadLine();
                            Console.Write("Yazar: ");
                            string yazar = Console.ReadLine();
                            Console.Write("Yayın Numarası (ISSN): ");
                            string yayinNo = Console.ReadLine();

                            Console.Write("Sayfa Sayısı: ");
                            int sayfasayisi = int.TryParse(Console.ReadLine(), out int ss) ? ss : 0;

                            Console.Write("Yayınevi: ");
                            string yayinevi = Console.ReadLine();
                            Console.Write("Tür: ");
                            string tur = Console.ReadLine();
                            Console.Write("Orijinal Dil: ");
                            string orijinaldil = Console.ReadLine();
                            Console.Write("Basım yılı: ");
                            string basimyili = Console.ReadLine();

                            zKitaplar kitap_bagis = new Romanlar(kitapadi, yazar, yayinNo, sayfasayisi, yayinevi, true, tur, orijinaldil, basimyili);
                            // TODO: İleride bu nesneyi kitaplars listesine ekleyecek kod buraya gelecek

                            Console.WriteLine("Bağışınız sisteme kaydedildi. Teşekkür ederiz!");
                        }
                        else
                        {
                            Console.WriteLine("Sistem: Yalnızca dergi ve okuma kitabı bağışı kabul edilmektedir.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("\n--- Kütüphanemizde Bulunan Kitaplar ---");
                        foreach (var kitap in kitaplars)
                        {
                            kitap.KitapBilgileriGoster();
                            Console.WriteLine("---------------------------");
                        }

                        Console.WriteLine("\n--- Kitap Ödünç Alma Ekranı ---");
                        Console.Write("Lütfen sistemde kayıtlı isminizi giriniz: ");
                        string uyeIsmi = Console.ReadLine();

                        // 1. AŞAMA: ÜYEYİ SİSTEMDE BULMA
                        bool uyeBulundu = false;
                        uyelikler aktifUye = null; // Üyeyi bulursak, bu boş kutunun içine koyacağız ki aşağıda kullanalım

                        foreach (var uye in uyeliklers)
                        {
                            // NOT: Kendi 'uyelikler' sınıfında isme ne dediysen (Isim, Ad vs.) onu yazmalısın.
                            if (uye.isim == uyeIsmi)
                            {
                                uyeBulundu = true;
                                aktifUye = uye; // Üyeyi yakaladık!
                                break;
                            }
                        }

                        if (uyeBulundu == false)
                        {
                            Console.WriteLine("HATA: Sistemde böyle bir üye bulunamadı. Lütfen önce 1. menüden kayıt olun.");
                            break; // Üye değilse programı hiç yorma, direkt işlemi iptal et
                        }

                        // 2. AŞAMA: KİTABI BULMA VE SÜREYİ HESAPLAMA
                        Console.Write("Ödünç almak istediğiniz kitabın adını tam olarak giriniz: ");
                        string istenenKitap = Console.ReadLine();
                        bool kitapBulundu = false;

                        foreach (var i in kitaplars)
                        {
                            if (i.kitapadi == istenenKitap)
                            {
                                kitapBulundu = true;

                                if (i.mevcutMu == true) // Kitap rafta mı?
                                {
                                    int oduncSuresi = 0;

                                    // İŞTE SİHİRLİ KISIM (is operatörü)
                                    // aktifUye'nin hangi sınıftan doğduğuna bakıyoruz
                                    if (aktifUye is GumusUye)
                                    {
                                        oduncSuresi = 10;
                                    }
                                    else if (aktifUye is AltinUye)
                                    {
                                        oduncSuresi = 20;
                                    }
                                    else if (aktifUye is ElmasUye)
                                    {
                                        oduncSuresi = 30;
                                    }

                                    // İşlemleri gerçekleştir
                                    i.mevcutMu = false; // Kitabı verdik
                                    DateTime teslimTarihi = DateTime.Now.AddDays(oduncSuresi);

                                    Console.WriteLine($"\nİŞLEM BAŞARILI! Sayın {aktifUye.isim}, '{i.kitapadi}' adlı kitabı ödünç aldınız.");
                                    Console.WriteLine($"Sahip olduğunuz üyelik tipine göre bu kitabı {oduncSuresi} gün kullanabilirsiniz.");
                                    Console.WriteLine($"İade tarihiniz: {teslimTarihi.ToString("dd.MM.yyyy")}");
                                }
                                else
                                {
                                    Console.WriteLine("Bu kitap kütüphanemizde var ama şu an başka bir üyemiz okuyor.");
                                }
                                break;
                            }
                        }

                        if (kitapBulundu == false)
                        {
                            Console.WriteLine("Kütüphanemizde böyle bir kitap bulunmamaktadır.");
                        }
                        break;

                        break;

                    case "6":
                        {
                            Console.WriteLine("\n--- Üyelik Bilgileri Ekranı ---");

                            if (uyeliklers.Count == 0)
                            {
                                Console.WriteLine("Sistem Uyarısı: Kütüphanemize henüz kayıtlı bir üye bulunmamaktadır...");
                                break;
                            }

                            var sonUye = uyeliklers[uyeliklers.Count - 1];

                            Console.WriteLine("\n==================================");
                            Console.WriteLine("        PROFİL BİLGİLERİNİZ       ");
                            Console.WriteLine("==================================");

                            Console.WriteLine($"Ad         : {sonUye.isim}");
                            Console.WriteLine($"Soyad      : {sonUye.soyisim}");
                            Console.WriteLine($"Doğum Yılı : {sonUye.dogumyili}");

                            string uyeTipi = "Belirsiz";
                            if (sonUye is GumusUye) uyeTipi = "Gümüş Üyelik";
                            else if (sonUye is AltinUye) uyeTipi = "Altın Üyelik";
                            else if (sonUye is ElmasUye) uyeTipi = "Elmas Üyelik";

                            Console.WriteLine($"Üyelik Tipi: {uyeTipi}");
                            Console.WriteLine($"Bakiye     : {bakiye} TL");

                            // YENİ EKLENEN KISIM: Ödünç Alınan Kitaplar Modülü
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("   ÖDÜNÇ ALINAN KİTAPLAR:");

                            // Çantanın (Listenin) içi boş mu dolu mu kontrolü
                            if (sonUye.OduncKitaplar != null && sonUye.OduncKitaplar.Count > 0)
                            {
                                // Çanta doluysa içindeki kitapları tek tek yazdır
                                foreach (var kitap in sonUye.OduncKitaplar)
                                {
                                    Console.WriteLine($"- {kitap}");
                                }
                            }
                            else
                            {
                                // Çanta boşsa senin istediğin o mesaj
                                Console.WriteLine("Mevcut değil");
                            }
                            Console.WriteLine("==================================\n");

                            break;
                        }


                    case "7":
                        Console.WriteLine("Sistemden çıkış yapılıyor. İyi günler!");
                        return; // return kullanarak programı güvenli bir şekilde kapatırız

                    default:
                        Console.WriteLine("Geçersiz işlem! Lütfen 1 ile 7 arasında bir sayı giriniz.");
                        break;
                }
            }
        }
    }
}