using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace jarmuvek
{
    internal class jarmu
    {

        public string Rendszam { get; set; }
        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value <= 0)
                {
                    alapar = 1000000;
                }

            }
        }
        private static int osszesJarmuSzama { get; set; }
        public static int OsszesJarmuSzama { get; }

        public jarmu(string rendszam, int alapar2)
        {
            Rendszam = rendszam;
            alapar = alapar2;
            osszesJarmuSzama++;
        }

        public virtual int Adokalkulacio(int Alapar)
        {
            return alapar;
        }

        public override string ToString()
        {
            return $"Jármű:{Rendszam} , Alapár:{Alapar}, Ado:{Adokalkulacio}";
        }
    }
}
