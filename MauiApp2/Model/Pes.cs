using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class Pes : Zvire
    {
        public Pes(string jmeno, int vaha) : base(jmeno, vaha)
        {
        }

        public override string VydejZvuk()
        {
            return "haf.... haf...";
        }
    }
}
