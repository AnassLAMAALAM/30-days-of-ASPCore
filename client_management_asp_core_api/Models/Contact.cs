using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace client_management_asp_core_api.Models
{
    public class Contact
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}
