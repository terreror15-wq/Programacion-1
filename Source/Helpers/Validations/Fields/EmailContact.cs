using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;

namespace ContactProyect.Helpers.Validations.Fields
{
    public class EmailContact
    {
        public static string FieldEmail()
        {
            string email;
            while (true)
            {
                Console.WriteLine("Enter the contat´s email you want to add");
                email = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Email cnat be empty");
                    continue;
                }
                if (email.Length < 5 || email.Length > 100)
                {
                    Console.WriteLine("Email must be between 5 and 100 characters");
                    continue;
                }
                if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.WriteLine("Invalid email format, please try again");
                    continue;
                }
                if (email.StartsWith("@") || email.StartsWith(".") || email.EndsWith("@") || email.EndsWith("."))
                {
                    Console.WriteLine("Invalid email format, please try again");
                    continue;
                }

                bool FoundEmail = AddForm.ListContacts.Any(x => x.Email == email);

                if (FoundEmail)
                {
                    Console.WriteLine("The email already exists");
                    continue;
                }
                break;
            }

            return email;
        }
    }
}