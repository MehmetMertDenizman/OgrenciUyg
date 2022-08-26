using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G034
{
    internal class Okul
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>();


        //NotEkle
        //OgrenciEkle
        //AdresGuncelle
        //OgrenciGuncelle
        //OgrenciListele
        public void OgrenciEkle(int no, string ad, string soyad, SUBE sube, CINSIYET cins, DateTime dogumTarihi, Adres.Il il, Adres.Ilce ilce)
        {
            Ogrenciler.Add(new Ogrenci(no, ad, soyad, sube, cins, dogumTarihi, il, ilce));
        }
        public static void NotEkle()
        {
            Console.WriteLine("20-Not Gir ----------------------------------------------------------");
            while (true)
            {
                try
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    Ogrenci ogrenci = Ogrenciler.Where(x => x.No == no).First();
                    Console.WriteLine("\nÖgrencinin Adı Soyadı: " + ogrenci.Ad + " " + ogrenci.Soyad + "\nÖgrencinin Subesi: " + ogrenci.Subesi + "\n");
                    if (!(no == ogrenci.No)) { Console.WriteLine(" Yok numara"); break; }

                    Console.Write("Not eklemek istediğiniz dersi giriniz: ");
                    DersAdi dersAdi = (DersAdi)Enum.Parse(typeof(DersAdi), Console.ReadLine());  
                    Console.Write("Eklemek istediginiz not adedi: ");
                    int noAdet = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= noAdet; i++) {

                        Console.Write(i+".Notu girin: ");
                        float not = float.Parse(Console.ReadLine());
                        DersNotu dn = new DersNotu(dersAdi, not);
                        Ogrenci.Notlar.Add(dn);
                        
                    }
                    Ogrenci.Notlar.ForEach(x => Console.WriteLine($"{x.DersAdi}   {x.Not}"));
                    break;
                }
                catch (System.InvalidOperationException) { Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin."); }
                catch (System.ArgumentException) { Console.WriteLine("Ders adı yanlış girildi."); }
                {
                      }
                
               
                
                
            }
        } // Ders adı sadece Matematik şeklinde kabul ediyor.
        public Ogrenci OgrenciMi(int ogrNo)
        {
            Ogrenci a = Ogrenciler.Where(x => x.No == ogrNo).FirstOrDefault();
            if (a != null)
            {
                return a;
            }

            return null;
        }
    }
}
