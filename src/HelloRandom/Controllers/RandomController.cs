using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloRandom.Service;
using Microsoft.AspNetCore.Mvc;

namespace HelloRandom.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return (new RandomService()).GenerateOutTradeNo();
        }

     
    }
}
