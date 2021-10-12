using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;



namespace Server7.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpPost]
        public string Messenger()
        {

            using (StreamReader reader = new StreamReader(HttpContext.Request.BodyReader.AsStream()))

            {
                var message = reader.ReadToEnd();
                return message + " Hi, Client! ";

                             
            }


        }


    }
}
