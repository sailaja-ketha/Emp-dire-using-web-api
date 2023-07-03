using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {

        private readonly ApplicationDbContext applicationDbContext;
        public JobTitleController(ApplicationDbContext context)
        {
            applicationDbContext = context;
        }

        // GET: api/<JobtitleController>
        [HttpGet]
        public IActionResult Get()
        {
            var data = applicationDbContext.JobTitles;
            return Ok(data);
        }

        // GET api/<JobtitleController>/5
        [HttpGet("{id}")]
        public JobTitle Get(int id)
        {
            return applicationDbContext.JobTitles.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<JobtitlesController>
        [HttpPost]
        public void Post([FromBody] JobTitle jobTitle)
        {
            applicationDbContext.JobTitles.Add(jobTitle);
            applicationDbContext.SaveChanges();
        }

        // PUT api/<JobtitleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] JobTitle jobTitle)
        {
            var data = applicationDbContext.JobTitles.SingleOrDefault(x => x.Id == id);
            data.Title = jobTitle.Title; 
            applicationDbContext.JobTitles.Update(data);
            applicationDbContext.SaveChanges();
        }

        // DELETE api/<JobtitleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = applicationDbContext.Employees.SingleOrDefault(x => x.Id == id);
            applicationDbContext.Employees.Remove(data);
            applicationDbContext.SaveChanges();
        }
    }
}

