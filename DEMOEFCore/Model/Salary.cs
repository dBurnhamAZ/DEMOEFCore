using System.ComponentModel.DataAnnotations;

namespace DEMOEFCore.Model
{
    public class Salary
    {
        public Salary()
        {
            Person = new HashSet<Person>();
        }

        [Key]
        public int SalaryId { get; set; }
        [Required]
        public int Amount { get; set; }

        public virtual ICollection<Person> Person { get; set; }

    }
}
