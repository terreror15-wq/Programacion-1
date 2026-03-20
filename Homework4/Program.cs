class Program
{
    static bool runing = true;
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
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
                    AddContact();
                    break;
                case 2:
                    ShowContacts();
                    break;
                case 3:
                    SearchContacts();
                    break;
                case 4:
                    UpdateContact();
                    break;
                case 5:
                    DeleteContact();
                    break;
                case 6:
                    runing = false;
                    break;
                default:
                    Console.WriteLine("You have selected the the incorrect option");
                    break;
            }
        }
    }

    class Contact
    {
        public int Id;
        public string Name;
        public string Lastname;
        public string Address;
        public string Telephone;
        public string Email;
        public int Age;
        public bool BestFriend;
    }

    static void AddContact()
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

        string lastname;
        while (true)
        {
            Console.WriteLine("Enter the person's lastname");
            lastname = Console.ReadLine()!.ToLower().Trim();

            if (string.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("the person´s last name can´t be empty");
                continue;
            }

            if (!lastname.All(char.IsLetter))
            {
                Console.WriteLine("only letters are allowed");
                continue;
            }
            break;
        }

        foreach (var c in contacts)
        {
            if (c.Name == name && c.Lastname == lastname)
            {
                Console.WriteLine("This contact already exists");
                return;
            }
        }

        string address;
        while (true)
        {
            Console.WriteLine("Enter the address");
            address = Console.ReadLine()!.ToLower().Trim();

            if (string.IsNullOrEmpty(address))
            {
                Console.WriteLine("Address can´t be empty");
                continue;
            }
            if (address.Length < 4)
            {
                Console.WriteLine("Address is too short, please try again");
                continue;
            }
            if (address.Length > 150)
            {
                Console.WriteLine("Address is too long, please try again");
                continue;
            }
            break;
        }

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
            if (contacts.Any(x => x.Telephone == phone))
            {
                Console.WriteLine("This phone number already exists");
                continue;
            }
            break;
        }

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

            if (contacts.Any(x => x.Email == email))
            {
                Console.WriteLine("The email already exists");
                continue;
            }
            break;
        }

        int age;
        while (true)
        {
            Console.WriteLine("Enter the contact's age");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("only numbers are allowed");
                continue;
            }
            if (age < 1 || age > 120)
            {
                Console.WriteLine("Invalid Age, try again");
                continue;
            }
            break;
        }

        bool BestFriend;
        while (true)
        {
            Console.WriteLine("is this your best friend (yes/no");
            string input = Console.ReadLine()!.ToLower().Trim();

            if (input == "yes")
            {
                BestFriend = true;
                break;
            }
            else if (input == "no")
            {
                BestFriend = false;
                break;
            }
            else
            {
                Console.WriteLine("please write yes or no");
            }
        }

        int id = 1;
        while (contacts.Any(x => x.Id == id))
        {
            id++;
        }

        Contact contact = new Contact();
        contact.Id = id;
        contact.Name = name;
        contact.Lastname = lastname;
        contact.Address = address;
        contact.Telephone = phone;
        contact.Email = email;
        contact.Age = age;
        contact.BestFriend = BestFriend;

        contacts.Add(contact);
    }

    static void ShowContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("There are no contacts to show yet");
            return;
        }

        Console.WriteLine($"Name          Lastname            Address           Telephone number            Email           Age            Best friend?");
        Console.WriteLine($"===========================================================================================================================");
        Console.WriteLine("contacts list");
        Console.WriteLine("============================================================================================================================");

        foreach (var c in contacts)
        {
            string bestfrienrtr = isBestFriendstrd(c.BestFriend);
            Console.WriteLine($"{c.Id}   {c.Name}         {c.Lastname}         {c.Address}         {c.Telephone}            {c.Email}            {c.Age}          {bestfrienrtr}");
        }
    }

    static string isBestFriendstrd(bool yesBestFriend)
    {
        if (yesBestFriend == true)
        {
            return "yes";
        }
        else
        {
            return "No";
        }
    }

    static void SearchContacts()
    {
        if (contacts.Count == 0)
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

        var c = contacts.FirstOrDefault(x => x.Id == inputID);

        if (c != null)
        {
            Console.WriteLine("contact found");
            string bestfrienrtr = isBestFriendstrd(c.BestFriend);
            Console.WriteLine($"Best friend: {bestfrienrtr}");
            Console.WriteLine($"Name: {c.Name}");
            Console.WriteLine($"Lastname: {c.Lastname}");
            Console.WriteLine($"Address: {c.Address}");
            Console.WriteLine($"Telephone number: {c.Telephone}");
            Console.WriteLine($"Email: {c.Email}");
            Console.WriteLine($"Age: {c.Age}");
            Console.WriteLine($"Best Friend: {bestfrienrtr}");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    static void DeleteContact()
    {
        if (contacts.Count == 0)
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

        var c = contacts.FirstOrDefault(x => x.Id == id);

        if (c == null)
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

        contacts.Remove(c);
        Console.WriteLine("contact deleted successfully");
    }

    static void UpdateContact()
    {
        if (contacts.Count == 0)
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

        var c = contacts.FirstOrDefault(x => x.Id == id);

        if (c == null)
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
            foreach (char ch in newName)
            {
                if (!char.IsLetter(ch) && ch != ' ')
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
        c.Name = newName;

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
            foreach (char ch in NewLastName)
            {
                if (!char.IsLetter(ch) && ch != ' ')
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
        c.Lastname = NewLastName;

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
        c.Address = NewAdderss;

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
            foreach (char ch in NewPhoneNumber)
            {
                if (!char.IsDigit(ch))
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
            if (contacts.Any(x => x.Telephone == NewPhoneNumber && x.Id != id))
            {
                Console.WriteLine("The number you are trying to update already exists");
                continue;
            }
            break;
        }
        c.Telephone = NewPhoneNumber;

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
            if (contacts.Any(x => x.Email == NewEmail && x.Id != id))
            {
                Console.WriteLine("Email already exists");
                continue;
            }
            break;
        }
        c.Email = NewEmail;

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
        c.Age = NewAge;

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
        c.BestFriend = NewBestFriend;

        Console.WriteLine("contact updated successfully");
    }
} 