using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{

    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows prntr;

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nmrPrntr = Convert.ToInt32(Console.ReadLine());

            if (nmrPrntr == 1)
            {
                prntr = new Epson();
            }
            else if (nmrPrntr == 2)
            {
                prntr = new Canon();
            }
            else
            {
                prntr = new LaserJet();
            }

            prntr.tmpl();
            prntr.Print();

            Console.ReadKey();
        }
    }
}

