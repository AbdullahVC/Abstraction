using Abstraction.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Constructor
{
    internal class SatısTemsilcisi : Calisan
    {

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
        }
    }
}
