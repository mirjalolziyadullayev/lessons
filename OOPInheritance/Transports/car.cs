using OOPInheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Transports
{
    internal class car : TransportParent
    {
        public void Wheels()
        {
            Console.WriteLine("car has 4 wheels");
        }
    }
}
