using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations.Fields
{
    public class AgeContact
    {
        public static int FieldAge()
        {

            int age;
            while (true)
            {
                Console.WriteLine("Enter the contact's age");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("only numbers are allowed");
                    continue;
                }
                if (age < 1 || age > 120)
                {
                    Console.WriteLine("Invalid Age, try again");
                    continue;
                }
                break;
            }
            return age;
        }
    }
}