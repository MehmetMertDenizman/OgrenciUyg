using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G034
{
    internal class Adres
    {
        public Il il { get; set; }
        public Ilce ilce { get; set; }  
        public string Semt;


        public enum Ilce
        {
            Empty, Gaziemir, Bakırköy, Çankaya
        }




        public enum Il{
            Empty, İstanbul, Ankara, İzmir
        }
    }
}
   
