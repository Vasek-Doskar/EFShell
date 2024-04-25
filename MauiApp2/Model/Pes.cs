using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class Pes 
    {
        public Pes(string jmeno, int vaha)
        {
            Jmeno = jmeno;
            Vaha = vaha;
        }

        public string Jmeno {  get; set; }
        public int Vaha { get; set; }


        public string VydejZvuk()
        {
            return "haf.... haf...";
        }
    }
}
