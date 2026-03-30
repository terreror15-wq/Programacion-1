using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;
using ContactProyect.Helpers.Validations.Messages;

namespace ContactProyect.Domain
{
    public class ShowAllContact
    {
        public static void ShowContacts()
        {
            if (AddForm.ListContacts.Count == 0)
            {
                Console.WriteLine("There are no contacts to show yet");
                return;
            }

            Console.WriteLine($"Name          Lastname            Address           Telephone number            Email           Age            Best friend?");
            Console.WriteLine($"===========================================================================================================================");
            Console.WriteLine("contacts list");
            Console.WriteLine("============================================================================================================================"); //
            foreach (var c in AddForm.ListContacts)
            {
                bool isBestFriend = c.BestFriend;
                string bestfrienrtr = BestFriendMessage.isBestFriendstrd(isBestFriend);
                Console.WriteLine($"{c.Id}   {c.Name}         {c.LastName}         {c.Address}         {c.Phone}            {c.Email}            {c.Age}          {bestfrienrtr}");

            }

        }
    }
}