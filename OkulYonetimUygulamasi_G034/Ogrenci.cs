using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G034
{
    internal class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DersAdi ders;
        public SUBE Subesi { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Adres.Il il;
        public Adres.Ilce ilce;
        
        public float NotOrtalamasi;
        public float NotOrtalamasiGet
        {
            get
            {
                float topla = 0;
                float sayac = 0;
                foreach (var item in Notlar)
                {
                    sayac++;
                    NotOrtalamasi +=  item.Not;
                    
                }
                NotOrtalamasi = topla / sayac;
                Console.WriteLine(NotOrtalamasi);
                return NotOrtalamasi; }
             
            
        }
        public int KitapSayisi { get; set; }
        public DersNotu Ders;


        public List<string> Kitaplar = new List<string>();
        public static List<DersNotu> Notlar = new List<DersNotu> ();
        
        public Ogrenci(int no, string ad, string soyad, SUBE sb, CINSIYET cins, DateTime dTarihi, Adres.Il il, Adres.Ilce ilce )
        {
          
            this.il = il;
            this.ilce = ilce;
             
            this.No = no;
            this.Ad = ad;
            this.Subesi = sb;
            this.Soyad = soyad;
            this.Cinsiyet = cins;
            this.DogumTarihi = dTarihi;
            //this.NotOrtalamasi = NotOrtalamasi;
        }
    }

    public enum SUBE
    {
        Empty, A, B, C
    }
    public enum CINSIYET
    {
        Empty, Kadin , Erkek
    }
}
