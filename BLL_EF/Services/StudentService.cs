using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Models;
using DAL;
using Microsoft.EntityFrameworkCore;

public class StudentService : IStudentService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public StudentService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<StudentResponseDTO> GetStudentAsync(int id)
    {
        var student = await _context.Students
            .Include(s => s.Grupa)
            .FirstOrDefaultAsync(s => s.ID == id);

        if (student == null) throw new KeyNotFoundException("Student not found");

        return _mapper.Map<StudentResponseDTO>(student);
    }

    public async Task<IEnumerable<StudentResponseDTO>> GetAllStudentsAsync()
    {
        var students = await _context.Students
            .Include(s => s.Grupa)
            .ToListAsync();

        return _mapper.Map<IEnumerable<StudentResponseDTO>>(students);
    }

    public async Task<StudentResponseDTO> AddStudentAsync(StudentRequestDTO studentDto)
    {
        var student = _mapper.Map<Student>(studentDto);
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        var createdStudent = await _context.Students
            .Include(s => s.Grupa)
            .FirstOrDefaultAsync(s => s.ID == student.ID);

        return _mapper.Map<StudentResponseDTO>(createdStudent);
    }

    public async Task UpdateStudentAsync(int id, StudentRequestDTO studentDto)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) throw new KeyNotFoundException("Student not found");

        _mapper.Map(studentDto, student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) throw new KeyNotFoundException("Student not found");

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
    }
}