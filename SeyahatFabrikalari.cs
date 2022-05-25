using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatilRez
{

    public abstract class SeyahatFabrikalari
    {
        public abstract UlasimBase UlasimYap();
        public abstract KonaklamaBase KonaklamaYap();

    }
    public class OtobusCadir : SeyahatFabrikalari
    {
        public override UlasimBase UlasimYap()
        {
            return new Otobus();
        }
        public override KonaklamaBase KonaklamaYap()
        {
            return new Cadir();
        }
    }
    public class OtobusOtel : SeyahatFabrikalari
    {
        public override UlasimBase UlasimYap()
        {
            return new Otobus();
        }
        public override KonaklamaBase KonaklamaYap()
        {
            return new Otel();
        }
    }
    public class UcakOtel : SeyahatFabrikalari
    {
        public override UlasimBase UlasimYap()
        {
            return new Ucak();
        }
        public override KonaklamaBase KonaklamaYap()
        {
            return new Otel();
        }
    }
    public class UcakCadir : SeyahatFabrikalari
    {
        public override UlasimBase UlasimYap()
        {
            return new Ucak();
        }
        public override KonaklamaBase KonaklamaYap()
        {
            return new Cadir();
        }
    }

}
