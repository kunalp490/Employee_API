using Employee_API.Model;
using Employee_API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public readonly IEmployee _IEmployee;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployee __IEmployee)
        {
            _logger = logger;
            _IEmployee = __IEmployee;
        }

        [HttpGet]
        public List<EmployeeList> Get()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();

            return _IEmployee.getAll_Employees();
        }

        [Route("{id}")]
        [HttpGet]
        public JsonResult get(int id)
        {
            return new JsonResult(_IEmployee.getEmployee_byID(id));
        }
    }
}
