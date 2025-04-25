using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentService
    {
        Task<StudentResponseDTO> GetStudentAsync(int id);
        Task<IEnumerable<StudentResponseDTO>> GetAllStudentsAsync();
        Task<StudentResponseDTO> AddStudentAsync(StudentRequestDTO studentDto);
        Task UpdateStudentAsync(int id, StudentRequestDTO studentDto);
        Task DeleteStudentAsync(int id);
    }
}
