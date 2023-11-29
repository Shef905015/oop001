using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop001ab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.ToString();

            osoba.setIme("Pero");
            osoba.setPrezime("Pikunelić");
            osoba.setVisina(169);
            osoba.setTezina(80);
            osoba.setGodinaRodjenja(1941);
            osoba.setSpol('M');

            Console.Write(osoba.ToString());

            Osoba osoba2 = new Osoba("Vladimir", "Nazor", 168, 85, 1895, 'M');

            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();
        }
    }
}
