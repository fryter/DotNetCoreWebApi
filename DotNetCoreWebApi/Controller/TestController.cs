using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Owin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DotNetCoreWebApa.Controllers
{
   public class TestController:Controller
    {

        public string test()
        {
            return "test";
        }
    }
}
