using Microsoft.EntityFrameworkCore;
using StudentManager.Domain.Interfaces.Repositories;
using StudentsManager.Domain.Models;
using StudentsManager.Domain.Bases;
using System.Linq;
using System.Threading.Tasks;
using StudentsManager.DataMongo.Context;
using System;

namespace StudentsManager.DataMongo.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentsManagerContext _context { get; }

        public StudentRepository(StudentsManagerContext context) : base(context)
        {
            _context = context;
        } 

        public async Task<PaginatedList<Student>> GetStudentsPagedAsync(int? pageSize = 1, int? page = 1)
        {
            //return await PaginatedList<Student>.CreateAsync(
            //               _context.Student
            //               .Include(i => i.Addresses)
            //               .Include(i => i.Course)
            //               .OrderBy(i => i.FirstName)
            //               .AsNoTracking()
            //               .AsQueryable(),
            //                page != null && page > 0 ? (int)page : 1,
            //                pageSize != null && pageSize > 0 ? (int)pageSize : 1);
            throw new NotImplementedException();
        }

        public async Task<PaginatedList<Student>> GetStudentsPagedByNameAsync(string name, int? pageSize = 1, int? page = 1)
        {
            //return await PaginatedList<Student>.CreateAsync(
            //               _context.Student
            //               .Include(i => i.Addresses)
            //               .Include(i => i.Course)
            //               .Where(i => i.FirstName.Contains(name))
            //               .OrderBy(i => i.FirstName)
            //               .AsNoTracking()
            //               .AsQueryable(),
            //                page != null && page > 0 ? (int)page : 1,
            //                pageSize != null && pageSize > 0 ? (int)pageSize : 1);
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            //return await _context.Student
            //          .Include(i => i.Addresses)
            //          .Include(i => i.Course)
            //          .OrderBy(i => i.FirstName)
            //          .AsNoTracking()
            //          .FirstOrDefaultAsync(i => i.Id == id);
            throw new NotImplementedException();
        }
 
    }
}
