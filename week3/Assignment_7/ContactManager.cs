using System;
using System.Collections.Generic;
using System.Linq;

class ContactManagement
{
    static List<Contact> contacts = new List<Contact>();
    public void getUserInput()
    {
        string input;
        do
        {

            Console.WriteLine("\n>>>> CONTACT MANAGEMENT SYSTEM <<<<\n");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display All Contacts");
            Console.WriteLine("3. Search Contact by Name");
            Console.WriteLine("4. Delete Contact by Name");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            input = Console.ReadLine() ?? "";
            switch (input)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    DisplayContacts();
                    break;
                case "3":
                    SearchContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (input != "5");
    }

    static void AddContact()
    {
        string name = Utils.GetValidString("Enter name: ");

        string phoneNumber = Utils.GetValidLong("Enter phoneNumber: ").ToString();

        Contact contact = new Contact(name, phoneNumber);
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully!");
    }

    static void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        Console.WriteLine("\n>>> All Contacts <<<");
        foreach (var c in contacts)
        {
            Console.WriteLine(c);
        }
    }

    static void SearchContact()
    {
        string search = Utils.GetValidString("Enter name to search: ").ToLower();

        var matches = contacts.Where(c => c.Name.ToLower().Contains(search)).ToList();

        if (matches.Count == 0)
        {
            Console.WriteLine("No contact found.");
            return;
        }

        Console.WriteLine("\n>>> Search Results <<<");
        foreach (var c in matches)
        {
            Console.WriteLine(c);
        }
    }

    static void DeleteContact()
    {
        string nameToDelete = Utils.GetValidString("Enter name to delete: ").ToLower();

        var found = contacts.FirstOrDefault(c => c.Name.ToLower() == nameToDelete);

        if (found != null)
        {
            contacts.Remove(found);
            Console.WriteLine("Contact deleted.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
