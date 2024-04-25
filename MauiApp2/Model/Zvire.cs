using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public abstract class Zvire
    {
        protected Zvire(string jmeno, int vaha)
        {
            Jmeno = jmeno;
            Vaha = vaha;
        }

        public string Jmeno {  get; set; }
        public int Vaha { get; set; }

        public abstract string VydejZvuk();

        public override string ToString() => $"{GetType()} jménem {Jmeno}";
    }
}
