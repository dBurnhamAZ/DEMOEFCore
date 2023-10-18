using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DEMOEFCore.Model
{
    public class Position
    {
        public Position()
        {
            Person = new HashSet<Person>();
        }

        [Key]
        public int PositionId { get; set; }
        [Required]
        public string PositionName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public virtual ICollection<Person> Person { get; set; }

    }
}
