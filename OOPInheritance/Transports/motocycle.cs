using OOPInheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Transports
{
    internal class Motocycle : TransportParent
    {
        public void Wheels()
        {
            Console.WriteLine("motocycle's wheels are 2");
        }
    }
}
