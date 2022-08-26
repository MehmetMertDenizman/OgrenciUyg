using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OkulYonetimUygulamasi_G034
{
    internal class Uygulama
    {
        public Ogrenci og;
        public DersNotu DersNotu;

        public Okul okul = new Okul();
        public void Calistir()
        {

            SahteVeriGir();
            //OgrenciListele();
            //SubeyeGoreListele();
            //SahteVeriGir();
            Menu();
            SecimAl();
            //switch-case
        }

        public void SahteVeriGir()
        {
            //Ogrenci o = new Ogrenci();
            //o.Ad = "";
            //o.Soyad = "";
            //o.Subesi = "";

            okul.OgrenciEkle(15, "AHMET", "DELİBAŞ", SUBE.B, CINSIYET.Erkek, new DateTime(2008, 05, 18), Adres.Il.İzmir, Adres.Ilce.Gaziemir);
            okul.OgrenciEkle(35, "VELİ", "KİMDİKİ", SUBE.A, CINSIYET.Erkek, new DateTime(2007, 05, 18), Adres.Il.Ankara, Adres.Ilce.Çankaya);
            okul.OgrenciEkle(25, "MAHMUT", "AYDA", SUBE.C, CINSIYET.Erkek, new DateTime(2007, 05, 20), Adres.Il.İstanbul, Adres.Ilce.Bakırköy);
            okul.OgrenciEkle(45, "DERVİŞ", "GİTMİŞ", SUBE.B, CINSIYET.Erkek, new DateTime(2006, 05, 18), Adres.Il.Ankara, Adres.Ilce.Çankaya);
            okul.OgrenciEkle(55, "PINAR", "TEK", SUBE.A, CINSIYET.Kadin, new DateTime(2004, 05, 18), Adres.Il.İzmir, Adres.Ilce.Gaziemir);
            okul.OgrenciEkle(65, "ECE", "ERKEN", SUBE.C, CINSIYET.Kadin, new DateTime(2001, 05, 18), Adres.Il.İstanbul, Adres.Ilce.Bakırköy);
            okul.OgrenciEkle(75, "SEDA", "SAYMAZ", SUBE.A, CINSIYET.Kadin, new DateTime(2003, 05, 18), Adres.Il.İzmir, Adres.Ilce.Gaziemir);
        }

        static void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----\n");
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele(Alfabetik sıralama olacak )");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele(Derse göre sıralayıp listelenecek)");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör(Öğrenciye ait ortalama özelliği olacak, set özelliği olmayacak, get özelliği içinde hesaplanıp döndürülecek)");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle(yeni öğrenci yaratılmayacak, var olan öğrenci nesnesi üzerinden güncelleme yapılacak.)");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir(Öğrencinin adresi farklı bir class olacak )");
            Console.WriteLine("19- Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20- Öğrencinin notunu gir(Metot ile giriş yapılacak)");
            Console.WriteLine("\nÇıkıs yapmak için \"çıkıs\" yazıp \"enter\"a basın.\n");
        }


        
        //  SAHTE ORTALAMA VE KİTAPLAR VE KİTAP SAYISI
       
        void SecimAl()
        {

            while (true)
            {
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                string secim = Console.ReadLine();
                if (secim == "liste") { Menu(); }
                if (secim == "çıkış") { Environment.Exit(0); break; }
                try
                {

                    Console.WriteLine("");
                    byte secimByte = Byte.Parse(secim);


                    if (secimByte > 0 && secimByte < 21)
                    {
                        switch (secim)
                        {

                            case "1": OgrenciListele(); break;
                            case "2": SubeyeGoreListele(); break;
                            case "3": CinsiyeteGoreListele(); break;
                            case "4": XTarihtenSonraDogan(); break;
                            case "5": IllereGoreListele(); break;
                            case "6": DerseGoreTumNotlar(); break;
                            case "7": OkuduguKitaplarListele(); break;
                            case "8": EnYuksek5Not(); break;
                            case "9": EnDusuk3Not(); break;
                            case "10": SubedekiEnYüksek5Not(); break;
                            case "11": SubedekiEnDusuk3Not(); break;
                            case "12": NotOrtalaması(); break;
                            //case "13":  SubeNotOrtalama(); break;
                            case "14": OgrencininOkuduguSonKitap(); break;
                            case "15": OgrenciEkle(); break;
                            case "16": OgrenciGuncelle(); break;
                            case "17": OgrenciSil(); break;
                            case "18": OgrenciAdresiEkle(); break;
                            case "19": OgrenciOkuduguKitap(); break;
                            case "20": NotEkle(); break;
                            case "çıkış":
                                Environment.Exit(0);
                                break;
                            case "liste":
                                Menu();
                                break;
                            default: break;
                        }

                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Hatalı islem gerçeklestirildi. Tekrar deneyin.");
                }
                Console.WriteLine("\nMenüyü tekrar listelemek için \"liste\", çıkıs yapmak için \"çıkış\" yazın.\n");
            }


        }

        void OgrenciListele()
        {
            Console.WriteLine("1-Bütün Ögrencileri Listele --------------------------------------------------\n");
            Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort. ",-13} {"Okuduğu Kitap Say."}"));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Okul.Ogrenciler.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5} {x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-11} {x.NotOrtalamasi,-13} {x.KitapSayisi.ToString()}")));


        } //OK 1111 OK
        void SubeyeGoreListele()
        {
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");
            while (true)
            {

                Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                try
                {

                    SUBE sube = (SUBE)Enum.Parse(typeof(SUBE), Console.ReadLine().ToUpper());
                    Console.WriteLine("");
                    if (sube == SUBE.A || sube == SUBE.B || sube == SUBE.C)
                    {
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort. ",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> SubeyeGoreListele = Okul.Ogrenciler.Where(x => x.Subesi == (SUBE)sube).OrderByDescending(x => x.Subesi).ToList();
                        SubeyeGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5}{x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-12} {x.NotOrtalamasi,-13} {x.KitapSayisi.ToString()}")));
                        break;
                    }
                    else { Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin."); }

                }
                catch (System.ArgumentException) { Console.WriteLine("Hatali giriş yapıldı. Tekrar deneyin."); }


            }

        } //OK 2222    1 2 3 İLE ÇAĞRILIYOR!!!!!!

        void CinsiyeteGoreListele()
        {
            Console.WriteLine("3-Cinsiyete Göre Öğrencileri Listele -----------------------------------------");
            while (true)
            {
                Console.Write("Listelemek istediğiniz cinsiyeti girin (K/E): ");
                try
                {

                    //CINSIYET cinsiyet = (CINSIYET)Enum.Parse(typeof(CINSIYET), Console.ReadLine().ToUpper());
                    string cinsiyet = Console.ReadLine().ToUpper();


                    string a = Enum.GetName(typeof(CINSIYET), 1);
                    string b = Enum.GetName(typeof(CINSIYET), 2);
                    if (cinsiyet == "K")
                    {
                        Console.WriteLine("");
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort. ",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> CinsiyeteGoreListele = Okul.Ogrenciler.Where(x => x.Cinsiyet == (CINSIYET.Kadin)).OrderByDescending(x => x.Cinsiyet).ToList();
                        CinsiyeteGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5}{x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-12} {x.NotOrtalamasi,-13} {x.KitapSayisi.ToString()}")));
                        break;
                    }
                    else if (cinsiyet == "E")
                    {
                        Console.WriteLine("");
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort. ",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> CinsiyeteGoreListele = Okul.Ogrenciler.Where(x => x.Cinsiyet == (CINSIYET.Erkek)).OrderByDescending(x => x.Cinsiyet).ToList();
                        CinsiyeteGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5} {x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-11} {x.NotOrtalamasi,-13} {x.KitapSayisi.ToString()}")));
                        break;
                    }
                    else { Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin."); }
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }


            }
        } //OK 333333 OK
        void XTarihtenSonraDogan()
        {

            while (true)
            {
                Console.Write("4-Dogum Tarihine Göre Ögrencileri Listele ------------------------------------\nHangi tarihten sonraki ögrencileri listelemek istersiniz: ");
                try
                {
                    DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    if (dogumTarihi.Year >= 1900)
                    {
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort. ",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> DogumTariheGoreListele = Okul.Ogrenciler.Where(x => x.DogumTarihi >= dogumTarihi).OrderByDescending(x => x.DogumTarihi).ToList();
                        DogumTariheGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5} {x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-11} {x.NotOrtalamasi,-13} {x.KitapSayisi.ToString()}")));
                        break;
                    }
                }
                catch { Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin."); }
            }
        } //OK 444444 OK
        void IllereGoreListele()
        {
            Console.WriteLine("5-İllere Göre Ögrencileri Listele --------------------------------------------");
            while (true)
            {
                Console.WriteLine("");
                try
                {


                    Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Şehir",-13} {"Semt"}"));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    List<Ogrenci> IllereGoreListele = Okul.Ogrenciler.OrderBy(x => x.il.ToString()).ToList();
                    IllereGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad.Substring(0, 1).ToUpper()}{x.Ad.Substring(1).ToLower(),-5} {x.Soyad.Substring(0, 1).ToUpper()}{x.Soyad.Substring(1).ToLower(),-11} {x.il,-13} {x.ilce}")));
                    break;
                }



                catch (Exception)
                {

                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }


            }
        } //OK 5555555 OK

        void DerseGoreTumNotlar()
        {
            bool check = true;
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");
            while (check)
            {
                try
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    if (okul.OgrenciMi(no) == null)
                    {
                        Console.WriteLine("Bu numarada bir öğrenci yok. Tekrar deneyin.");
                        continue;
                    }
                    Okul.Ogrenciler.Where(x => x.No == no).ToList().ForEach(
                        x =>
                        {
                            if (no == x.No)
                            {
                                Console.WriteLine("\nÖgrencinin Adı Soyadı: " + x.Ad.Substring(0, 1).ToUpper() + x.Ad.Substring(1).ToLower() + " " + x.Soyad.Substring(0, 1).ToUpper() + x.Soyad.Substring(1).ToLower() + "\nÖgrencinin Subesi: " + x.Subesi.ToString());
                                Console.WriteLine($"{"\nDersin Adı",-16} {"Notu"}\n-------------------------");
                                Ogrenci.Notlar.ForEach(x => Console.WriteLine(String.Format($"{x.DersAdi,-15} {x.Not}")));
                                check = false;


                            }

                        });




                }
                catch (System.FormatException) { Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin"); }
            }

        } // OK 666666 OK

        void OkuduguKitaplarListele()
        {

            Console.WriteLine();
            Console.WriteLine("7-Ögrencinin okudugu kitapları listele ---------------------------------------");

            do
            {
                try
                {
                    int ogrNo;
                    Console.Write("Ögrencinin numarasi: ");
                    if (int.TryParse(Console.ReadLine(), out ogrNo))
                    {
                        if (okul.OgrenciMi(ogrNo) == null)
                        {
                            Console.WriteLine("Bu numarada bir öğrenci yok. Tekrar deneyin.");
                            continue;
                        }

                        else
                        {

                            Ogrenci ogr = okul.OgrenciMi(ogrNo);

                            Console.WriteLine();
                            Console.WriteLine("Ögrencinin Adı Soyadı:" + ogr.Ad.Substring(0, 1).ToUpper() + ogr.Ad.Substring(1).ToLower() + " " + ogr.Soyad.Substring(0, 1).ToUpper() + ogr.Soyad.Substring(1).ToLower());
                            Console.WriteLine("Ögrencinin Subesi: " + ogr.Subesi + Environment.NewLine);
                            Console.WriteLine("Okuduğu Kitaplar");
                            Console.WriteLine("-----------------");



                            foreach (var kitap in ogr.Kitaplar)
                            {
                                Console.WriteLine(kitap);
                            }


                            Console.WriteLine();
                            Console.WriteLine("Menüyü tekrar listelemek için ''liste'', çıkış yapmak için ''çıkış'' yazın." + Environment.NewLine);
                            break;
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }
            } while (true);
        }  //  77777777777 DENE !!!!

        void EnYuksek5Not()
        {

            //Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            //string giris = Console.ReadLine().ToUpper();   // Buraya bunun bir şube olup olmadığına dair bir kontrol girilebilir mi ? 
            //SUBE sube = (SUBE)Enum.Parse(typeof(SUBE), giris);

            List<Ogrenci> liste;
            liste = Okul.Ogrenciler.OrderByDescending(x => x.NotOrtalamasi).Take(5).ToList();

            Console.WriteLine();
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------" + Environment.NewLine);
            Listele(liste);
        } // OK 8 OK

        void EnDusuk3Not()
        {
            List<Ogrenci> liste;
            liste = Okul.Ogrenciler.OrderBy(x => x.NotOrtalamasi).Take(3).ToList();

            Console.WriteLine();
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele -----------------------------------" + Environment.NewLine);
            Listele(liste);

        } // OK 9 OK
        void SubedekiEnYüksek5Not()
        {
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");
            while (true)
            {
                Console.WriteLine("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                try
                {

                    SUBE sube = (SUBE)Enum.Parse(typeof(SUBE), Console.ReadLine().ToUpper());
                    if (sube == SUBE.A || sube == SUBE.B || sube == SUBE.C)
                    {
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort.",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> SubeyeGoreListele = Okul.Ogrenciler.Where(x => x.Subesi == (SUBE)sube).OrderByDescending(x => x.NotOrtalamasi).ToList();
                        SubeyeGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad,-6} {x.Soyad,-12} {x.NotOrtalamasi,-13} {x.KitapSayisi}")));
                        break;
                    }
                    else if (sube >= SUBE.C)
                    { Console.WriteLine("Daha küçük sayı gir"); }
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin.");
                }
            }




        }//OK 10
        void SubedekiEnDusuk3Not()
        {
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");
            while (true)
            {
                Console.WriteLine("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                try
                {

                    SUBE sube = (SUBE)Enum.Parse(typeof(SUBE), Console.ReadLine().ToUpper());
                    if (sube == SUBE.A || sube == SUBE.B || sube == SUBE.C)
                    {
                        Console.WriteLine(String.Format($"{"Şube",-6} {"No",-7} {"Adı Soyadı",-19} {"Not Ort.",-13} {"Okuduğu Kitap Say."}"));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        List<Ogrenci> SubeyeGoreListele = Okul.Ogrenciler.Where(x => x.Subesi == (SUBE)sube).OrderBy(x => x.NotOrtalamasi).ToList();
                        SubeyeGoreListele.ForEach(x => Console.WriteLine(String.Format($"{x.Subesi,-6} {x.No.ToString(),-7} {x.Ad,-6} {x.Soyad,-12} {x.NotOrtalamasi,-13} {x.KitapSayisi}")));
                        break;
                    }
                    else if (sube >= SUBE.C)
                    { Console.WriteLine("Daha küçük sayı gir"); }
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin.");
                }
            }
        } // OK 11
        void NotOrtalaması()
        {

            Console.WriteLine("12-Ögrencinin Not Ortalamasını Gör ----------------------------------");

            Okul.Ogrenciler.ForEach(x => Console.WriteLine(x.NotOrtalamasi));




        } // 12 olmadı

        // WIP 12
        void OgrencininOkuduguSonKitap()
        {

            Console.WriteLine("14-Ögrencinin okudugu son kitabı listele ----------------------------");
            while (true)
            {
                Console.Write("Ögrencinin numarasi:");
                int no = Convert.ToInt32(Console.ReadLine());


                if (okul.OgrenciMi(no) == null)
                {
                    Console.WriteLine("Bu numarada bir öğrenci yok. Tekrar deneyin.");
                    continue;
                }
                else
                {
                    try
                    {
                        Ogrenci ogr = okul.OgrenciMi(no);

                        Console.WriteLine();
                        Console.WriteLine("Ögrencinin Adı Soyadı: " + ogr.Ad.Substring(0, 1).ToUpper() + ogr.Ad.Substring(1).ToLower() + " " + ogr.Soyad.Substring(0, 1).ToUpper() + ogr.Soyad.Substring(1).ToLower());
                        Console.WriteLine("Ögrencinin Subesi: " + ogr.Subesi + Environment.NewLine);
                        Console.WriteLine("Ögrencinin Okudugu Son Kitap");
                        Console.WriteLine("-----------------------------");
                        string sonKitap = ogr.Kitaplar.Last().ToLower();

                        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                        Console.WriteLine(textInfo.ToTitleCase(sonKitap));
                        break;
                    }
                    catch (System.InvalidOperationException)
                    {
                        Console.WriteLine();
                    }

                }
            }

        }// 14
        public void OgrenciEkle()
        {
            //int ogr_no,string ogrAd,string ogrSoyad, SUBE sube, CINSIYET cinsiyet, DateTime dogumTarihi 
            Console.WriteLine("15-Öğrenci Ekle -----------------------------------------------------");

            bool kontrol3 = true;
            CINSIYET cinsiyet = CINSIYET.Empty;
            SUBE sube = SUBE.Empty;
            int ogr_no;
            string ogrAd;
            string ogrSoyad;
            DateTime dogumTarihi;
            string ogrCinsiyet;
            string ogrSube;
            float NotOrtalamasi;

            while (kontrol3 == true)
            {
                Console.Write("Ögrencinin numarası: ");

                ogr_no = int.Parse(Console.ReadLine());

                Console.Write("Ögrencinin adı: ");
                ogrAd = Console.ReadLine();
                Console.Write("Ögrencinin soyadı: ");
                ogrSoyad = Console.ReadLine();
                Console.WriteLine("Ögrencinin dogum tarihi: ");
                dogumTarihi = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ögrencinin cinsiyeti:e/k: ");
                ogrCinsiyet = Console.ReadLine().ToUpper();

                bool kontrol = true;
                while (kontrol == true)
                {
                    if (ogrCinsiyet == "E")
                    {
                        cinsiyet = CINSIYET.Erkek;
                        kontrol = false;

                    }
                    else if (ogrCinsiyet == "K")
                    {
                        cinsiyet = CINSIYET.Kadin;
                        kontrol = false;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. ");

                        Console.WriteLine("Ögrencinin cinsiyeti:e/k: ");
                        kontrol = true;

                    }
                    kontrol = false;

                }
                Console.WriteLine("Ögrencinin subesi (A/B/C): ");
                ogrSube = Console.ReadLine().ToUpper();

                bool kontrol1 = true;
                while (kontrol1 == true)
                {
                    if (ogrSube == "A")
                    {
                        sube = SUBE.A;
                        kontrol1 = false;
                    }
                    else if (ogrSube == "B")
                    {
                        sube = SUBE.B;
                        kontrol1 = false;

                    }
                    else if (ogrSube == "C")
                    {
                        sube = SUBE.C;
                        kontrol1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız.");
                        Console.WriteLine("Ögrencinin subesi (A/B/C): ");
                        kontrol1 = true;
                    }
                    kontrol1 = false;
                }
                okul.OgrenciEkle(ogr_no, ogrAd, ogrSoyad, sube, cinsiyet, dogumTarihi, Adres.Il.İstanbul, Adres.Ilce.Gaziemir);
                Console.WriteLine("Öğrenci başarılı bir şekilde eklendi.");
                kontrol3 = false;
            }











        }// OK 15

        void OgrenciGuncelle()
        {
            bool check = true;
            Console.WriteLine("16 - Ögrenci Güncelle-----------------------------------------------------------");
            while (check)
            {
                try
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    foreach (Ogrenci item in Okul.Ogrenciler)
                    {
                        if (no == item.No)
                        {
                            Console.Write("Öğrencinin adı: ");
                            string ad = Console.ReadLine();
                            item.Ad = ad;
                            Console.Write("Öğrencinin soyadı: ");
                            string soyAd = Console.ReadLine();
                            item.Soyad = soyAd;
                            Console.Write("Ögrencinin dogum tarihi: ");
                            DateTime dogum = DateTime.Parse(Console.ReadLine());
                            Console.Write("Öğrencinin cinsiyeti (K/E): ");
                            string cinsiyet = Console.ReadLine().ToUpper();
                            if (cinsiyet == "K") { item.Cinsiyet = CINSIYET.Kadin; }
                            else if (cinsiyet == "E") { item.Cinsiyet = CINSIYET.Erkek; }
                            Console.Write("Ögrencinin subesi (A/B/C): ");
                            string sube = Console.ReadLine().ToUpper();
                            if (sube == "A") { item.Subesi = SUBE.A; }
                            else if (sube == "B") { item.Subesi = SUBE.B; }
                            else if (sube == "C") { item.Subesi = SUBE.C; }
                            Console.WriteLine("\nÖğrenci güncellendi.");
                            check = false;
                            break;

                        }
                        else if (no != item.No) { Console.WriteLine("Bu numarada bir ögrenci yok. Tekrar deneyin."); break; }



                    }
                }
                catch (System.FormatException) { Console.WriteLine("Hatali giris yapildi. Tekrar deneyin"); }
            }

        }// 16 OK
        void OgrenciSil()
        {
            bool check = true;
            Console.WriteLine("17-Ögrenci sil ----------------------------------------------------------------");
            while (check) try
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    foreach (Ogrenci item in Okul.Ogrenciler)
                    {
                        if (no == item.No)
                        {
                            Console.Write("\nÖgrencinin Adı Soyadı: " + item.Ad + " " + item.Soyad + "\n" + "Ögrencinin Subesi: " + item.Subesi);
                            Console.Write("\n\nÖgrenciyi silmek istediginize emin misiniz (E/H): ");
                            string emin = Console.ReadLine().ToUpper();
                            if (emin == "E")
                            {
                                Console.WriteLine("Ögrenci basarılı bir sekilde silindi.");
                                Okul.Ogrenciler.Remove(item);
                                check = false;
                                break;
                            }
                            else if (emin == "H") { check = false; break; }


                        }
                        else if (no != item.No) { Console.WriteLine("Bu numarada bir ögrenci yok. Tekrar deneyin."); break; }



                    }
                }
                catch (System.FormatException) { Console.WriteLine("Hatali giris yapildi. Tekrar deneyin"); }
        } // 17 OK

        void OgrenciAdresiEkle()
        {
            bool check = true;
            Console.WriteLine("18 - Ögrencinin Adresini Gir ------------------------------------------");
            while (check) try
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    foreach (Ogrenci item in Okul.Ogrenciler)
                    {
                        if (no == item.No)
                        {
                            //Console.Write("\nÖgrencinin Adı Soyadı: " + item.Ad + " " + item.Soyad + "\n" + "Ögrencinin Subesi: " + item.Subesi);
                            //Console.Write("\n\nİl ");
                            //Adres il = AdresConsole.ReadLine().ToUpper();
                            //if (il == "E")
                            //{
                            //    Console.WriteLine("Ögrenci basarılı bir sekilde silindi.");
                            //    Okul.Ogrenciler.Remove(item);
                            //    check = false;
                            //    break;
                            //}
                            //else if (emin == "H") { check = false; break; }


                        }
                        else if (no != item.No) { Console.WriteLine("Bu numarada bir ögrenci yok. Tekrar deneyin."); break; }



                    }
                }
                catch (System.FormatException) { Console.WriteLine("Hatali giris yapildi. Tekrar deneyin"); }
        }// 18
        void OgrenciOkuduguKitap()
        {
            Console.WriteLine();
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ------------------------------------");

            do
            {
                try
                {
                    int ogrNo;
                    Console.Write("Ögrencinin numarasi: ");
                    if (int.TryParse(Console.ReadLine(), out ogrNo))
                    {
                        if (okul.OgrenciMi(ogrNo) == null)
                        {
                            Console.WriteLine("Bu numarada bir öğrenci yok. Tekrar deneyin.");
                            continue;
                        }

                        else
                        {

                            Ogrenci ogr = okul.OgrenciMi(ogrNo);

                            Console.WriteLine();
                            Console.WriteLine("Ögrencinin Adı Soyadı:" + ogr.Ad.Substring(0, 1).ToUpper() + ogr.Ad.Substring(1).ToLower() + " " + ogr.Soyad.Substring(0, 1).ToUpper() + ogr.Soyad.Substring(1).ToLower());
                            Console.WriteLine("Ögrencinin Subesi: " + ogr.Subesi + Environment.NewLine);

                            Console.Write("Eklenecek kitabın adı: ");
                            string kitapAdi = Console.ReadLine();
                            ogr.Kitaplar.Add(kitapAdi);
                            Console.WriteLine("Bilgiler sisteme girilmiştir.");
                            break;
                        }

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }
            } while (true);
        } // 19
        void NotEkle()
        {
            Okul.NotEkle();
















            //Console.Write("Ögrencinin numarasi: ");
            //int no = int.Parse(Console.ReadLine());
            ////no bilgi ile öğrenci tespit ediilecek..
            //Console.Write("Ögrencinin Adı Soyadı: " + og.Ad);
            //Console.Write("Ögrencinin Subesi: ");
            //Console.WriteLine();
            //DersAdi ders = DersAdi.Empty;
            //Console.Write("Not eklemek istediğiniz ders: ");
            ////string ders = Console.ReadLine();

            //Console.Write("Eklemek istediginiz not adedi: ");
            //int adet = int.Parse(Console.ReadLine());
            //float not;
            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Notu girin: ");
            //    not = float.Parse(Console.ReadLine());
            //    Okul.NotEkle(no, ders, not);
            //}

        } // OK 20,0000000000000000000000000000,000000000
          // 


        void Listele(List<Ogrenci> liste)
        {
            Console.WriteLine("Şube".PadRight(8) + "No".PadRight(8) + "Adı Soyadı".PadRight(20) + "Not Ort. ".PadRight(14) + "Okuduğu Kitap Say.");
            Console.WriteLine("-------------------------------------------------------------------------------");

            foreach (Ogrenci ogr in liste)
            {
                Console.WriteLine($"{ogr.Subesi,-7} {ogr.No.ToString(),-7} {ogr.Ad.Substring(0, 1).ToUpper()}{ogr.Ad.Substring(1).ToLower(),-5} {ogr.Soyad.Substring(0, 1).ToUpper()}{ogr.Soyad.Substring(1).ToLower(),-11} {ogr.NotOrtalamasi,-13} {ogr.KitapSayisi.ToString()}");
            }

            
             
        } //OK
    }
}