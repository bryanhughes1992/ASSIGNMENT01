using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASSIGNMENT01_N00481777_BRYANHUGHES.Controllers
{
    public class GreetingsController : ApiController
    {
        // POST: api/greetings
        public string Post()
        {
            string Greeting = "Hello World!";
            return Greeting;
        }

        // GET: api/greetings/{id}
        public string Get(int id)
        {
            int NumberOfPeople = id;
            string Greeting = $"Greetings to {NumberOfPeople} people!";
            return (Greeting);
        }
    }
    
}