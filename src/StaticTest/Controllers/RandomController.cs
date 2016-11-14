using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaticTest.Service;

namespace StaticTest.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return RandomService.GenerateOutTradeNo();
        }

    }
}
