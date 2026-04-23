using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.StatusMenu
{
    internal class statusMenu
    {
        public static string Statusmenu()
        {
            
            
                int Option;
                do
                {
                    Console.WriteLine("Select the status");
                    Console.WriteLine(" 1.Available\n 2.In use\n 3.Under Maintenance\n 4.Out of Service");
                    Option = int.Parse(Console.ReadLine()!);

                } while (Option < 1 || Option > 4);
                switch (Option)
                {
                    case 1:
                        {
                            return "Available";
                        }
                        
                    case 2:
                        {
                            return "In use";
                        }
                        
                    case 3:
                        {
                            return "Under Maintenance";
                        }
                        
                    case 4:
                        {
                            return "Out of Service";
                        }
                        
                    default: return "";
                }
            
        }
    }
}
