using ContactProyect.Domain;
using ContactProyect.Helpers.Form;

bool runing = true;

while (runing)
{
    Console.WriteLine(@"1. Add contact     2. See Contact    3. Search Contacts     4. Update Contact   5. Delete Contact    6. Exit");
    Console.WriteLine("Write the number of the desired option");
    if (!int.TryParse(Console.ReadLine(), out int typOption))
    {
        Console.WriteLine("Invalid option");
        continue;
    }
    if (typOption < 1 || typOption > 6)
    {
        Console.WriteLine("Please select a number between 1 and 6");
        continue;
    }

    switch (typOption)
    {
        case 1:
            {
                AddForm.formContact();
            }
            break;
        case 2: //extract this to a method
            {
                ShowAllContact.ShowContacts();
            }
            break;
        case 3: //search
            {
                SearchContact.SearchContacts();
            }
            break;
        case 4:
            {
               UpdateContacts.UpdateContact();  
            }
            break;
        case 5: //delete
            {
                RemoveContact.DeleteContact();
            }
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("You have selected the the incorrect option");
            break;
    }
}
