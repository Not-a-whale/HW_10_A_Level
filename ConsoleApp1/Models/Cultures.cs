using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10.Models
{
    internal class Cultures
    {
        public Cultures(string en, string ru, string num)
        {
            this.En = en;
            this.Ru = ru;
            this.Num = num;
        }

        public string En { get; set; }

        public string Ru { get; set; }

        public string Num { get; set; }
    }
}
