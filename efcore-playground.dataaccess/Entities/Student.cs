using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace efcore_playground.dataaccess.entities
{
    public class Student
    {

        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }

        public virtual Address Address { get; set; }
    }
}
