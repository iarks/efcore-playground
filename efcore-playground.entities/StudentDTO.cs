using System.Collections.Generic;

namespace efcore_playground.entities
{
    public class StudentDTO
    {
        public StudentDTO(string iD, string name, AddressDTO address, IEnumerable<GradeDTO> grades)
        {
            ID = iD;
            Name = name;
            Grades = grades;
            Address = address;
        }

        public string ID { get; }

        public string Name { get; }

        public IEnumerable<GradeDTO> Grades { get; }

        public AddressDTO Address { get; }
    }
}
