using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public  static class Vehicle_Factory
    {
        public static Ivehicle GetVehicle(string numberoftires) 
        {switch (numberoftires) 
            {
                case "2":
                    return new motorcycle();
                case "4":
                    return new car();
                default:
                    return new car();
            
            
            
            }
        
        
        
        }
        
         
        
        

    }
}
