using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProyect.Helpers.Form;
using ContactProyect.Models;

namespace ContactProyect.Domain
{
    public class AddContacts
    {
        static int idCount = 1;
        public static void AddContact(Contact c)
        {
            c.Id = idCount++;
            AddForm.ListContacts.Add(c);
            Console.WriteLine("Contact added ");
        }
    }
}
