using HW_10.Services;
using System.Text.RegularExpressions;

namespace HW_10.Models
{
    internal class ContactsBook
    {
        private static List<Contact> phoneBook = new List<Contact>();
        private static Regex regex = new Regex("^[0-9]+$");
        public static void AddAContact()
        {
            Console.WriteLine("Please input a name: ");
            string? name = Console.ReadLine();
            if(name == null || name.Length == 0)
            {
                ContactsService.WrongInput();
                return;
            }
            Console.WriteLine("Please input a phone number: ");
            string? number = Console.ReadLine();
            if(number == null || number.Length == 0 || !regex.IsMatch(number))
            {
                ContactsService.WrongInput();
                return;
            }
            phoneBook.Add(new Contact(name, number));
        }
        public static void DeleteAContact()
        {
            Console.WriteLine("Please input a name of a contact you want to find: ");
            string? name = Console.ReadLine();
            if (name == null || name.Length == 0)
            {
                ContactsService.WrongInput();
                return;
            }
            Contact? contactFound = phoneBook.Find(elem => elem.Name == name);
            if(contactFound == null)
            {
                Console.WriteLine("There is no contact like that in the phone book");
            }
            else
            {
                int index = phoneBook.IndexOf(contactFound);
                phoneBook.RemoveAt(index);
                Console.WriteLine($"The contact {contactFound.Name} has been removed");
            }
        }

        public static void FindAndShowAContact()
        {
            Console.WriteLine("Please input a name of a contact you want to find: ");
            string? name = Console.ReadLine();
            if (name == null || name.Length == 0)
            {
                ContactsService.WrongInput();
                return;
            }
            Contact? contactFound = phoneBook.Find(elem => elem.Name == name);
            if(contactFound == null)
            {
                Console.WriteLine("There is no contact like that in the phone book");
            }
            else
            {
                Console.WriteLine($"{contactFound.Name} - {contactFound.PhoneNumber}");
            }
        }

        public static void ListAllContacts()
        {
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Name} - {contact.PhoneNumber} - {contact.Grouping}");
            }
        }
    }
}
