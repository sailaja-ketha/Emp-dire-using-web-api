using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;
        public DepartmentController(ApplicationDbContext context)
        {
          applicationDbContext=context;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = applicationDbContext.Departments;
            return Ok(data);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return applicationDbContext.Departments.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public void Post([FromBody] Department department)
        {
            applicationDbContext.Departments.Add(department);
            applicationDbContext.SaveChanges();
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Department department)
        {
            var data = applicationDbContext.Departments.SingleOrDefault(x => x.Id == id);
            data.Name= department.Name;
            applicationDbContext.Departments.Update(data);
            applicationDbContext.SaveChanges();
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = applicationDbContext.Departments.SingleOrDefault(x => x.Id == id);
            applicationDbContext.Departments.Remove(data);
            applicationDbContext.SaveChanges();
        }
    }
}
