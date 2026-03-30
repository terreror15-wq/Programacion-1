using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations
{
    public class LastNameContact
    {
        public static string FieldLastName()
        {
            string lastname;
            while (true)
            {
                Console.WriteLine("Enter the person's lastname");
                lastname = Console.ReadLine()!.ToLower().Trim();

                if (string.IsNullOrEmpty(lastname))
                {
                    Console.WriteLine("the person´s last name can´t be empty");
                    continue;
                }


                if (!lastname.All(char.IsLetter))
                {
                    Console.WriteLine("only letters are allowed");
                    continue;
                }
                break;
            }

            return lastname;
        }
    }
}