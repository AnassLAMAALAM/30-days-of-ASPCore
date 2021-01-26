using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using client_management_asp_core_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace client_management_asp_core_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            //CRUD
            using (var _context = new ClientManagementDBContext())
            {
                //Create
                //Client client = new Client();
                //client.Name = "Anass";
                //client.Email = "Anass";
                //client.Phone = "Anass";
                //_context.Clients.Add(client);
                //_context.SaveChanges();

                //Get All
                //return _context.Clients.ToList(); 

                //Update
                //Client client = _context.Clients.FirstOrDefault();
                //client.Name = "Anass";
                //client.Email = "Anass@gmail.com";
                //client.Phone = "0777097979";
                //_context.SaveChanges();
                return _context.Clients.ToList();

                //Remove 
                //Client client = _context.Clients.FirstOrDefault();
                //_context.Clients.Remove(client);

            }

        }
    }
}
