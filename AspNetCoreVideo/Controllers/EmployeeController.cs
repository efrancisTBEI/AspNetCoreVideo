using Microsoft;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {
        }

        [Route("")]
        [Route("[action]")]
        public string Index()
        {
            return "Hello from employee.";
        }

        [Route("[action]")]
        public ContentResult Name()
        {
            return Content("Jonas");
        }

        [Route("[action]")]
        public string Country()
        {
            return ("United States of America");
        }

    }
}
