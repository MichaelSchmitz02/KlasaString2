using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {

        Console.Write("Unesite Niz Znakova: ");
        string unos = Console.ReadLine();
        string rezultat = ZamijeniRazmake(unos);
        Console.WriteLine("Rezultat Zamjene Razmaka: " + rezultat);
    }
    static string ZamijeniRazmake(string ulaz)
    {
        return ulaz.Replace(' ', '_');
    }
}

