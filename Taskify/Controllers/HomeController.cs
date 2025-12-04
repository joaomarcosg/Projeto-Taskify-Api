using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Taskify.ModelViews;

namespace Taskify.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public HomeView Index()
        {
            return new HomeView
            {
                Message = "Welcome to the Task API",
                Documentation = "/swagger"
            };
        }
    }
}