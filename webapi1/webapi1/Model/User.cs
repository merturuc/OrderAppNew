using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Officephone { get; set; }
        public int Mobilephone { get; set; }
        public int Faxadress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}
