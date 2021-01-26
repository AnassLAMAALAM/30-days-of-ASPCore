using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace client_management_asp_core_api.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }



        internal string _Contact { get; set; }

        [NotMapped]
        public Contact Contact
        {
            get { return _Contact == null ? null : JsonConvert.DeserializeObject<Contact>(_Contact); }
            set { _Contact = JsonConvert.SerializeObject(value); }
        }






    }
}
