using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ContactProyect.Models;
using ContactProyect.Helpers.Validations;
using ContactProyect.Helpers.Validations.Fields;
using ContactProyect.Domain;

namespace ContactProyect.Helpers.Form
{
    public class AddForm
    {
        public static List<Contact> ListContacts = new List<Contact>();
        public static void formContact()
        {
            string name = NameContact.FieldName();
            string lastname = LastNameContact.FieldLastName();
            string address = AddressContact.FieldAddress();
            string phone = PhoneContact.FieldPhone();
            int age = AgeContact.FieldAge();
            string email = EmailContact.FieldEmail();
            bool BestFriend = BestFriendContact.FieldBestFriend();

            var contact = new Contact
            {
                Name = name,
                LastName = lastname,
                Address = address,
                Phone = phone,
                Age = age,
                Email = email,
                BestFriend = BestFriend
            };

            AddContacts.AddContact(contact);
        }
    }
}