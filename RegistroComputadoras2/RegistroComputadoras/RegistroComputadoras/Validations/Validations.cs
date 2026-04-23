using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Validations
{
    public class Validation
    {
        public static string ValidateString()
        {
            while (true)
            {
                string input = Console.ReadLine()!.ToLower().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("this field can't be empty \n Try again: ");
                    continue;
                }
                if(input.Length < 1 || input.Length > 50)
                {
                    Console.WriteLine("This field must be between 1 and 50 characters");
                    continue;
                }
                bool OnlyLetters = true;
                foreach(var c in input)
                {
                    if(!char.IsLetter(c) && c != ' ')
                    {
                        OnlyLetters = false;
                        break;
                    }
                }
                if (!OnlyLetters)
                {
                    Console.WriteLine("Only letters are are available");
                    continue;

                }
                return input;


            }
        }
    }
}
