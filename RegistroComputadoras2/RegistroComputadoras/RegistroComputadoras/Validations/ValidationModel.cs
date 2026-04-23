using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Validations
{
    public class ValidationModel
    {
        public static string Validationmodel()
        {
            while (true)
            {
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("This field cna't be empty");
                    continue;
                }
                if(input.Length < 2 || input.Length > 40)
                {
                    Console.WriteLine("This field mut be between 2 and 40 characters");
                    continue;
                }
                if(input.Contains("@") || input.Contains("#"))
                {
                    Console.WriteLine("This field can't conatin @ or #: \n try again: ");
                    continue;
                }
                return input;
            }
        }
    }
}
