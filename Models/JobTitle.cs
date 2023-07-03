using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDirectory.Models
{
    [Table("JobTitle")]
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }

   
    }
}
