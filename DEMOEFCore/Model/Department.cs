using System.ComponentModel.DataAnnotations;

namespace DEMOEFCore.Model
{
    public class Department
    {
        public Department()
        {
            Position = new HashSet<Position>();
        }

        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public virtual ICollection<Position> Position { get; set; }

    }
}
