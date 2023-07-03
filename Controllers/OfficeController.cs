using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public OfficeController(ApplicationDbContext context)
        {
            applicationDbContext = context;
        }

        // GET: api/<officeController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = applicationDbContext.offices;
            return Ok(data);
        }

        // GET api/<officeController>/5
        [HttpGet("{id}")]
        public Office Get(int id)
        {
            return applicationDbContext.offices.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<officesController>
        [HttpPost]
        public void Post([FromBody] Office office)
        {
            applicationDbContext.offices.Add(office);
            applicationDbContext.SaveChanges();
        }

        // PUT api/<officeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Office office)
        {
            var data = applicationDbContext.offices.SingleOrDefault(x => x.Id == id);
            data.Name=office.Name;
            data.Location=office.Location;
            applicationDbContext.offices.Update(data);
            applicationDbContext.SaveChanges();
        }

        // DELETE api/<officeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = applicationDbContext.offices.SingleOrDefault(x => x.Id == id);
            applicationDbContext.offices.Remove(data);
            applicationDbContext.SaveChanges();
        }
    }
}
