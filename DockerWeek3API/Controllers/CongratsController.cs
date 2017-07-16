using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerWeek3API.Controllers
{
    [Produces("application/json")]
    [Route("api/Congrats")]
    public class CongratsController : Controller
    {
        public string Get()
        {
            return "Congratulations Rob, on winning San Francisco Consultant of the Quarter!!!";
        }
    }
}