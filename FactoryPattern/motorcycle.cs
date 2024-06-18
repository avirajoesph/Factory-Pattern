using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class motorcycle:Ivehicle
    {
        public void Build() 
        {
            Console.WriteLine("building new motorcycle");
        
        }
    }
}
