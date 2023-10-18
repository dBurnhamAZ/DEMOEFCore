using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DEMOEFCore.Model
{
    public class PersonDetail
    {
        [Key]
        public int PersonDetailId { get; set; }
        public string PersonCity { get; set; }
        public DateTime Birthday { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
