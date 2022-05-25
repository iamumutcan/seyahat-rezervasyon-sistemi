using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatilRez
{
    public abstract class RezBilgi
    {
        public int RezId { get; set; }
        public string TCKN { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string KonaklamaTuru { get; set; }
        public string UlasimTuru { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public DateTime GidisTarih { get; set; }
        public DateTime DonusTarih { get; set; }
    }
}
