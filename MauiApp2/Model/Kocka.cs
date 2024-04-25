using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class Kocka : Zvire
    {
        public Kocka(string jmeno, int vaha) : base(jmeno, vaha)
        {
        }

        public override string VydejZvuk()
        {
            return "Meowwwww!";
        }
    }
}
