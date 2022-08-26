using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G034
{
    internal class DersNotu
    {
        public DersAdi DersAdi { get; set;}
        public float Not { get; set; }
        public DersNotu(DersAdi dersAdi, float not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }
    }
    public enum DersAdi
    {
        Empty, Matematik, Türkçe, Fen, Sosyal
    }
}
