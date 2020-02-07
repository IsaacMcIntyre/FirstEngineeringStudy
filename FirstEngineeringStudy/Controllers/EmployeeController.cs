using System;
using System.Threading.Tasks;
using FirstEngineeringStudy.BusinessLayer;
using FirstEngineeringStudy.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;

namespace FirstEngineeringStudy.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDataRetrieval _dataRetrieval;

        public EmployeeController(IEmployeeDataRetrieval dataRetrieval)
        {
            _dataRetrieval = dataRetrieval;
        }

        [HttpGet]
        public async Task<ActionResult<EmployeeResponseVm[]>> Get()
        {
            var data = _dataRetrieval.GetEmployees();
            return Ok(data);
        }
        
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<int> GetById(int id)
        {
            return Ok(id);
        }
        
        [HttpPut]
        public IActionResult Put()
        {
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return CreatedAtAction("GetById", new { id = 1 }, null);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
