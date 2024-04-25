using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class Pes 
    {
        public Pes()
        {
        }
        public Pes(string jmeno, int vaha, int Id) : this()
        {
            Jmeno = jmeno;
            Vaha = vaha;
            this.Id = Id;
        }

        public int Id {  get; set; }
        public string Jmeno {  get; set; }
        public int Vaha { get; set; }


        public override string ToString()
        {
            return $"ID:{Id} \"{Jmeno}\", {Vaha}kg";
        }

        public string VydejZvuk()
        {
            return "haf.... haf...";
        }
    }
}
