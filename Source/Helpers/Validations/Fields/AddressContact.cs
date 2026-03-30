using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations.Fields
{
    public class AddressContact
    {
        public static string FieldAddress()
        {
            string address;
            while (true)
            {
                Console.WriteLine("Enter the address");
                address = Console.ReadLine()!.ToLower().Trim();

                if (string.IsNullOrEmpty(address))
                {
                    Console.WriteLine("Address can´t be empty");

                    continue;
                }
                if (address.Length < 4)
                {
                    Console.WriteLine("Address is too short, please try again");
                    continue;
                }
                if (address.Length > 150)
                {
                    Console.WriteLine("Address is too long, please try again");
                    continue;
                }
                break;
            }

            return address;
        }
    }
}