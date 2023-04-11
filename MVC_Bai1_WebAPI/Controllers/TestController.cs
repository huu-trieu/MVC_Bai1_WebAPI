using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Bai1_WebAPI.Controllers
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web API ! ";
        }
        public List<string> Get(int Id)
        {
            return new List<string> { "Data 1", "Data 2", "Data 3" };
        }
    }
}
