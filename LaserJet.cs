using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_interface
{
    class LaserJet : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12 ");
        }

        public void tmpl()
        {
            Console.WriteLine("LaserJet printer printing.......");
        }
    }
}

