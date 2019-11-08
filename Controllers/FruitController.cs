using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Forms.Models;

namespace MVC_Forms.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        List<String> myFruit = new List<string>(){
            "apple",
            "orange",
            "grape"
        };

        public IEnumerable<String> Index(){
            myFruit.Add("bananas");
            return myFruit;
        }
        
    }
}
