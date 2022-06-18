using HW_10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10.Controllers
{
    internal class AddContacts
    {
        public static int InteractionInterface()
        {
            int optionCounter = 5;
            Console.WriteLine("Hi, this is your phone book");
            Console.WriteLine("1 - Add new contact");
            Console.WriteLine("2 - List all contacts");
            Console.WriteLine("3 - Find a contact");
            Console.WriteLine("4 - Delete a contact");
            Console.WriteLine("5 - exit");
            string? numInput = Console.ReadLine();
            int n;
            bool isNumeric = int.TryParse(numInput, out n);
            if (!isNumeric || n == 0 || n > optionCounter || n < 0)
            {
                ContactsService.WrongInput();
                InteractionInterface();
            }
            else
            {
                return n;
            }
            return 0;
        }
    }
}
