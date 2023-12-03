using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AnimalSound.Interfaces;

namespace AnimalSound
{
    public class Goat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Mheeeeeh");
        }
    }
}

