using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatilRez
{

    public abstract class UlasimBase
    {
        public string UlasimTipi { get; set; }
        public int UlasimFiyati { get; set; }
        public abstract void Ulas();
    }
    public class Ucak : UlasimBase
    {
        public override void Ulas()
        {
            UlasimTipi = "Uçak";
            UlasimFiyati = 759;
        }
    }
    public class Otobus : UlasimBase
    {
        public override void Ulas()
        {
            UlasimTipi = "Otobüs";
            UlasimFiyati = 289;
        }
    }
}
