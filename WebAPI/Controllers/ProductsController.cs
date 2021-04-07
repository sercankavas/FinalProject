using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "hei";
        }
    }
}
