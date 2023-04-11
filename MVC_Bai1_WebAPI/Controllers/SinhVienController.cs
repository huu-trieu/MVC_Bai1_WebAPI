using MVC_Bai1_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Bai1_WebAPI.Controllers
{
    public class SinhVienController : ApiController
    {
        public SinhVien Get()
        {
            SinhVien sv = new SinhVien();
            return sv;
        }
    }
}
