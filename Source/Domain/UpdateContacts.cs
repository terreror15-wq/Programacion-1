using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;

namespace ContactProyect.Domain
{
    public class UpdateContacts
    {
        public static void UpdateContact()
        {
            if (AddForm.ListContacts.Count == 0)
            {
                Console.WriteLine("There are no contats to update");
                return;
            }
            Console.WriteLine("write the contact id that you want to update");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("invalid ID");
                return;
            }
            var contact = AddForm.ListContacts.Where(x => x.Id == id).FirstOrDefault();
            if (id != contact!.Id)
            {
                Console.WriteLine("Contact not found");
                return;
            }
            string newName;
            while (true)
            {
                Console.WriteLine("Write the new name");
                newName = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(newName))
                {
                    Console.WriteLine("New name cnat be empty");
                    continue;
                }
                if (newName.Length > 50)
                {
                    Console.WriteLine("New name is too logn please try again");
                    continue;
                }
                bool onlyLetters = true;

                foreach (char c in newName)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        onlyLetters = false;
                        break;
                    }

                }
                if (!onlyLetters)
                {
                    Console.WriteLine("Only letters are allowed");
                    continue;
                }
                break;


            }
            contact.Name = newName;

            string NewLastName;
            while (true)
            {
                Console.WriteLine("Enter a new last name");
                NewLastName = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(NewLastName))
                {
                    Console.WriteLine("Last name cant be empty");
                    continue;
                }
                if (NewLastName.Length > 50)
                {
                    Console.WriteLine("New last name is too long, try again");
                    continue;
                }
                bool OnlyLEtters = true;

                foreach (char c in NewLastName)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        OnlyLEtters = false;
                        break;
                    }


                }
                if (!OnlyLEtters)
                {
                    Console.WriteLine("only letters are allowed");
                    continue;
                }
                break;
            }
            contact.LastName = NewLastName;

            string NewAdderss;
            while (true)
            {
                Console.WriteLine("Write the new address");
                NewAdderss = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(NewAdderss))
                {
                    Console.WriteLine("Address can´t be empty");
                    continue;
                }
                if (NewAdderss.Length < 5)
                {
                    Console.WriteLine("Address is too short please try again");
                    continue;
                }
                if (NewAdderss.Length > 150)
                {
                    Console.WriteLine("Address is too long please try again");
                    continue;
                }
                break;
            }
            contact.Address = NewAdderss;

            string NewPhoneNumber;
            while (true)
            {
                Console.WriteLine("Enter the new phone number");
                NewPhoneNumber = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(NewPhoneNumber))
                {
                    Console.WriteLine("Phone number can´t be empty");
                    continue;
                }
                bool OnlyNumbers = true;
                foreach (char c in NewPhoneNumber)
                {
                    if (!char.IsDigit(c))
                    {
                        OnlyNumbers = false;
                        break;
                    }
                }
                if (!OnlyNumbers)
                {
                    Console.WriteLine("Only numbers are allowed");
                    continue;
                }

                if (NewPhoneNumber.Length != 10)
                {
                    Console.WriteLine("New phone number must to have 10 digits please try again");
                    continue;
                }
                bool foundPhone = AddForm.ListContacts.Any(p => p.Phone == NewPhoneNumber);
                if (foundPhone)
                {
                    Console.WriteLine("The number you are trying to update already exists");
                    continue;
                }
                break;

            }
            contact.Phone = NewPhoneNumber;

            string NewEmail;
            while (true)
            {
                Console.WriteLine("Enter the new email");
                NewEmail = Console.ReadLine()!.ToLower().Trim();
                if (string.IsNullOrEmpty(NewEmail))
                {
                    Console.WriteLine("Email can´t be empty");
                    continue;
                }
                if (NewEmail.Length < 5 || NewEmail.Length > 100)
                {
                    Console.WriteLine("New email must be between 5 and 100 characters");
                    continue;
                }
                if (!NewEmail.Contains("@") || !NewEmail.Contains("."))
                {
                    Console.WriteLine("The new email is in invalid format, please try again");
                    continue;
                }
                
                bool FoundEmail = AddForm.ListContacts.Any(p => p.Email == NewEmail);
                if (FoundEmail)
                {
                    Console.WriteLine("Email already exists");
                    continue;
                }
                break;
            }
            contact.Email = NewEmail;
            int NewAge;
            while (true)
            {
                Console.WriteLine("Enter the new age");
                if (!int.TryParse(Console.ReadLine(), out NewAge))
                {
                    Console.WriteLine("Only numbers are allowed, please try again");
                    continue;
                }
                if (NewAge < 1 || NewAge > 120)
                {
                    Console.WriteLine("Invalid age, try again");
                    continue;
                }
                break;
            }
            contact.Age = NewAge;

            bool NewBestFriend = true;
            while (true)
            {
                Console.WriteLine("Is this your new best friend? (yes/no)");
                string input = Console.ReadLine()!.ToLower().Trim();
                if (input == "yes")
                {
                    NewBestFriend = true;
                    break;
                }
                else if (input == "no")
                {
                    NewBestFriend = false;
                    break;
                }
                else
                {
                    Console.WriteLine("please write Yes or no");
                }
            }
            contact.BestFriend = NewBestFriend;

            Console.WriteLine("contact updated successfully");
        }
    }
}