using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;

namespace ContactProyect.Helpers.Validations.Fields
{
    public class PhoneContact
    {
        public static string FieldPhone()
        {
            string phone;
            while (true)
            {
                Console.WriteLine("Enter the person´s number you want to add");
                phone = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(phone))
                {
                    Console.WriteLine("Phone can´t be empty");
                    continue;
                }

                bool onlyNumbes = true;
                foreach (char c in phone)
                {
                    if (!char.IsDigit(c))
                    {
                        onlyNumbes = false;

                        break;
                    }
                }
                if (!onlyNumbes)
                {
                    Console.WriteLine("Only numbers allowed");
                    continue;
                }


                if (phone.Length != 10)
                {
                    Console.WriteLine("phone number must to have 10 digits");
                    continue;
                }
                bool foundPhone = AddForm.ListContacts.Any(x => x.Phone == phone);

                if (foundPhone)
                {
                    Console.WriteLine("This phone number already exists");
                    continue;
                }
                break;
            }

            return phone;
        }
    }
}