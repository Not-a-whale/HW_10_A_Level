using HW_10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10.Models
{
    internal class Contact
    {
        public Contact(string name, string number)
        {
            this.Name = name;
            this.PhoneNumber = number;
            this.Grouping = this.IsName(name);
        }
        public string Name { get; set; }
        public string Grouping { get; set; }
        public string PhoneNumber { get; set; }

        private string IsName(string val)
        {
            return ContactsService.FindGrouping(val);
        }
    }
}
