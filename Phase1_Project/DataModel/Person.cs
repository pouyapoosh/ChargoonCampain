using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phase1_Project.Enum;

namespace Phase1_Project.DataModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int PersonalID { get; set; }
        public string Address { get; set; }
    }
}
