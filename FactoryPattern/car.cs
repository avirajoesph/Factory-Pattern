using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
        public class car : Ivehicle
        {
        public void Build()
        {

            Console.WriteLine("building new car");
        }
        }
}