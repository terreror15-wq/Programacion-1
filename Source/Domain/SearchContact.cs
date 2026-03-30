using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;
using ContactProyect.Helpers.Validations.Messages;

namespace ContactProyect.Domain
{
    public class SearchContact
    {
        public static void SearchContacts()
        {
            if (AddForm.ListContacts.Count == 0)
            {
                Console.WriteLine("There are no contacts to search");
                return;
            }
            Console.WriteLine("enter the ID contact you eant to seacrh");
            bool searchID = int.TryParse(Console.ReadLine(), out int inputID);

            if (!searchID)
            {
                Console.WriteLine("invalid ID");

                return;
            }
            var ContactFound = AddForm.ListContacts.Where(x => x.Id == inputID).FirstOrDefault();
            if (ContactFound is null)
            {
                Console.WriteLine("Contact not found");
                return;
            }
            if (AddForm.ListContacts.Contains(ContactFound))
            {
                Console.WriteLine("contact found");
                bool isBestFriend = ContactFound.BestFriend;
                string bestfrienrtr = BestFriendMessage.isBestFriendstrd(isBestFriend);
                Console.WriteLine($"Best friend: {bestfrienrtr}");
                Console.WriteLine($"Name: {ContactFound.Name}");
                Console.WriteLine($"Lastname: {ContactFound.LastName}");
                Console.WriteLine($"Address: {ContactFound.Address}");
                Console.WriteLine($"Telephone number: {ContactFound.Phone}");
                Console.WriteLine($"Email: {ContactFound.Email}");
                Console.WriteLine($"Age: {ContactFound.Age}");
                Console.WriteLine($"Best Friend: {bestfrienrtr}");

            }



        }
    }
}