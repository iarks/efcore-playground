using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore_playground.dataaccess.entities
{
    public class Address
    {
        [Key]
        public string ID { get; set; }
        
        public string StreetName { get; set; }
        
        public int Pin { get; set; }

        // Navigation to parent student

        [ForeignKey("Student")]
        public virtual string StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
