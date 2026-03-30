using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;

namespace ContactProyect.Domain
{
    public class RemoveContact
    {
        public static void DeleteContact()
        {
            if (AddForm.ListContacts.Count == 0)
            {
                Console.WriteLine("There are no contacts to delete");
                return;
            }
            Console.WriteLine("Write the id´s contact that you want to delete");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("invalid ID");
                return;
            }
            var contact = AddForm.ListContacts.Where(x => x.Id == id).FirstOrDefault();
            if (id != contact!.Id)
            {
                Console.WriteLine("contact not found");
                return;
            }
            while (true)
            {
                Console.WriteLine("Are you sure you want to delete this contact? (yes/no)");
                string confirm = Console.ReadLine()!.ToLower().Trim();

                if (confirm == "yes")
                {
                    break;
                }
                else if (confirm == "no")
                {
                    Console.WriteLine("Deletion cancelled");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write yes or no");
                }
            }
            AddForm.ListContacts.Remove(contact);
            Console.WriteLine("contact deleted successfully");


        }
    }
}