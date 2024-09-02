using Abstraction.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Constructor
{
    internal class YazilimGeliştiricisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
        }
    }
}
