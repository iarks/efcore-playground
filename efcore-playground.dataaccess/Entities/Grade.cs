using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace efcore_playground.dataaccess.entities
{
    public class Grade
    {
        [Key]
        public string GradeId { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
    }
}
