using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Program
    {
        public static void Main()
        {
            car mobil1 = new car();

            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 4;
            mobil1.Merk = "TOYOTA";
            mobil1.Model = "CAMRY";
            mobil1.TahunKeluar = 2022;

            mobil1.Gas(150);
            mobil1.Klakson("tiiinn...tiiinn");
            mobil1.Tampilkaninfo();



            Console.Write("Press C to close this program ");
            while (Console.ReadKey().Key != ConsoleKey.C) { }
        }
    }
}
