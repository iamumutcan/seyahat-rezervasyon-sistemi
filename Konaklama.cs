using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatilRez
{
    public abstract class KonaklamaBase
    {
        public string KonaklamaTipi { get; set; }
        public int KonaklamaFiyati { get; set; }
        public abstract void Konak();
    }
    public class Otel : KonaklamaBase
    {
        public override void Konak()
        {
            KonaklamaTipi = "Otel";
            KonaklamaFiyati = 349;
        }
    }
    public class Cadir : KonaklamaBase
    {
        public override void Konak()
        {
            KonaklamaTipi = "Çadır";
            KonaklamaFiyati = 40;

        }
    }
}
