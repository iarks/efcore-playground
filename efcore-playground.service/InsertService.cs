using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using efcore_playground.dataaccess;
using efcore_playground.entities;

namespace efcore_playground.service
{
    public class InsertService
    {
        private readonly DataAccessGet _dataAccessGet;
        public InsertService(DataAccessGet databaseGet)
        {
            _dataAccessGet = databaseGet;
        }

        public async Task<StudentDTO> InsertRandom()
        {
            AddressDTO ad = new AddressDTO("some street", 1234);
            StudentDTO s = new StudentDTO(null, "random", ad, null);
            var x= await _dataAccessGet.InsertStudent(s);
            return x;
        }
        
        public async Task<List<StudentDTO>> GetAllStudents()
        {
            var x = await _dataAccessGet.GetAllStudents();
            return x;
        }

        public async Task AddNewGrade()
        {
            GradeDTO gradeDTO = new GradeDTO()
            {
                Marks = 12,
                Subject = "JJ"
            };
            await _dataAccessGet.AddNewGrade(gradeDTO, "147137f8-c3d9-4854-bb3b-af9be026cc69");
        }

    }
}
