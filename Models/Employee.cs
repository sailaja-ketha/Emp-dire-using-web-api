using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDirectory.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string PreferredName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public string Image { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }  
        public string SkypeId { get; set; }
    }
}
