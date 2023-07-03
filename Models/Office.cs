using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDirectory.Models
{
    [Table("Office")]
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
