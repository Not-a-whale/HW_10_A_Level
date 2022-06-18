using HW_10.Controllers;
using HW_10.Models;

namespace HW_10
{
    internal class Program
    {
        public static void Main(string[]? args)
        {
            int response = 0;
            while (response != 5)
            {
                response = AddContacts.InteractionInterface();

                if(response == 1)
                {
                    ContactsBook.AddAContact();
                }
                if (response == 4)
                {
                    ContactsBook.DeleteAContact();
                }
                if (response == 3)
                {
                    ContactsBook.FindAndShowAContact();
                }
                if (response == 2)
                {
                    ContactsBook.ListAllContacts();
                }
            }

        }
    }
}