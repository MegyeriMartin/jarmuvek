using System;
using System.Collections.Generic;
using System.Text;

namespace jarmuvek
{
    internal class Teherauto : jarmu
    {
        public double Teherbiras { get; set; }

        public Teherauto (string Rendszam, int alapar, int teherbiras) : base(Rendszam, alapar)
        {
            Teherbiras = teherbiras;

        }

        public override int Adokalkulacio(int Alapar)
        {
            return (base.Adokalkulacio(Alapar) + Convert.ToInt32(Teherbiras) * 10000);
            
        }

        public override string ToString()
        {
            return base.ToString()+$"; Teherbirás: {Teherbiras}";
        }
    }
}
