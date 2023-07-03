using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDirectory.Models
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set;
        }
    }
}
