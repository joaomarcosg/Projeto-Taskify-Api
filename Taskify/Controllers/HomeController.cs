using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Taskify.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public string Index()
        {
            return "Hello, World!";
        }
    }
}