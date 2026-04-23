using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Validations
{
    public class ValidateBrand
    {
        public static string Validatebrand()
        {
            while (true)
            {
                string input = Console.ReadLine()!.ToLower().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("this field can't be empty \n Try againg: ");
                    continue;
                }
                if (input.Length < 2 || input.Length > 20)
                {
                    Console.WriteLine("This field must be between 2 and 20 characters");
                    continue;
                }
                bool OnlyLetters = true;
                foreach (char c in input)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        OnlyLetters = false;
                    }
                }
                if (!OnlyLetters)
                {
                    Console.WriteLine("Only letters are aloweed");
                    continue;
                }
                return input;
            }
            
        }
    }
}
