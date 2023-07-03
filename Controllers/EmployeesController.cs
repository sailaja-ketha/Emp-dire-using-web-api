using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext  applicationDbContext;
        public EmployeesController(ApplicationDbContext context) 
        {
            applicationDbContext = context;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = applicationDbContext.Employees;
            return Ok(data);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return applicationDbContext.Employees.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            applicationDbContext.Employees.Add(employee);
            applicationDbContext.SaveChanges();
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            var data = applicationDbContext.Employees.SingleOrDefault(x => x.Id == id);
            data.Email = employee.Email;
            data.FirstName = employee.FirstName;
            data.LastName = employee.LastName;
            data.Department = employee.Department;
            data.Office = employee.Office;
            data.PreferredName = employee.PreferredName;
            data.SkypeId = employee.SkypeId;    
            data.JobTitle = employee.JobTitle;
            data.PhoneNumber = employee.PhoneNumber;
            applicationDbContext.Employees.Update(data);
            applicationDbContext.SaveChanges();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data =  applicationDbContext.Employees.SingleOrDefault(x => x.Id == id);
            applicationDbContext.Employees.Remove(data);
            applicationDbContext.SaveChanges();
        }
    }
}
