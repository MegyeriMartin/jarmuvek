using jarmuvek;
using System.Globalization;

List<jarmu> autok = new List<jarmu>();
int hibassor = 0;

foreach (string sor in File.ReadAllLines("jarmuvek.csv").Skip(1))
{
    string[] adatok = sor.Split(';');
    if (adatok.Length == 3)
    {
        hibassor++;
        continue;
    }
    string tipus = adatok[0].Trim();
    string rendszam = adatok[1].Trim();
    int alapar = int.Parse(adatok[2].Trim());
    string extra = adatok[3].Trim();

    if ( !int)

}