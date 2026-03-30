using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations
{
    public class NameContact
    {
        public static string FieldName()
        {
            string name;
            while (true)
            {
                Console.WriteLine("enter the name of the person you want to add");
                name = Console.ReadLine()!.ToLower().Trim();
                name = string.Join(" ", name.Split(' ', StringSplitOptions.RemoveEmptyEntries));

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("the person´s name can´t be empty");
                    continue;

                }
                if (name.Length > 50)
                {
                    Console.WriteLine("name is too long please try again");
                    continue;
                }
                bool onlyLetters = true;
                foreach (char c in name)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        onlyLetters = false;
                        break;
                    }
                }
                if (!onlyLetters)
                {
                    Console.WriteLine("Only letters allowed");
                    continue;
                }
                break;
            }

            return name;
        }
    }

}