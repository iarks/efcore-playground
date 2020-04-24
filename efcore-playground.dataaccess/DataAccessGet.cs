using AutoMapper;
using efcore_playground.dataaccess.entities;
using efcore_playground.entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcore_playground.dataaccess
{
    public class DataAccessGet
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public DataAccessGet(ApplicationDbContext dbContext, IMapper mapper)
        {
            _applicationDbContext = dbContext;
            _mapper = mapper;
        }

        async public Task<StudentDTO> InsertStudent(StudentDTO studentDTO)
        {
            var newStu = _mapper.Map<Student>(studentDTO);

            _applicationDbContext.Add(newStu);
            await _applicationDbContext.SaveChangesAsync();
            return studentDTO;
        }

        async public Task<List<StudentDTO>> GetAllStudents()
        {
            List<Student> students = await _applicationDbContext.Students.Include(s => s.Address).ToListAsync();
            var studentDTOs = _mapper.Map<List<Student>, List<StudentDTO>>(students);
            return studentDTOs;
        }

        async public Task AddNewGrade(GradeDTO gradeDTO, string studentId)
        {
            var student = await _applicationDbContext.Students.Where(x => x.ID == studentId).Include(x => x.Grades).FirstOrDefaultAsync();
            var grade = _mapper.Map<GradeDTO, Grade>(gradeDTO);
            student.Grades.Add(grade);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
