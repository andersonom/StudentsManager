using Microsoft.EntityFrameworkCore;
using StudentManager.Domain.Interfaces.Repositories;
using StudentsManager.Domain.Models;
using StudentsManager.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsManager.DataMongo.Context;

namespace StudentsManager.DataMongo.Repositories
{
    public class CourseRepository : RepositoryBase<Course> 
    {
        public StudentsManagerContext _context { get; }

        public CourseRepository(StudentsManagerContext context) : base(context)
        {
            _context = context;
        }
        public async Task<PaginatedList<Course>> GetCoursesPagedByNameAsync(string name, int? pageSize, int? page)
        {
            //return await PaginatedList<Course>.CreateAsync(
            //      _context.Course
            //      .Where(i => i.Name.Contains(name))
            //      .OrderBy(i => i.Name)
            //      .AsNoTracking()
            //      .AsQueryable(),
            //       page != null && page > 0 ? (int)page : 1,
            //       pageSize != null && pageSize > 0 ? (int)pageSize : 1);
            throw new NotImplementedException();
        }

        public async Task<PaginatedList<Course>> GetCoursesPagedAsync(int? pageSize, int? page)
        {
            //return await PaginatedList<Course>.CreateAsync(
            //       _context.Course
            //       .OrderBy(i => i.Name)
            //       .AsNoTracking()
            //       .AsQueryable(),
            //        page != null && page > 0 ? (int)page : 1,
            //        pageSize != null && pageSize > 0 ? (int)pageSize : 1);
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesAsync()
        {
            //return await
            //       _context.Course
            //       .OrderBy(i => i.Name)
            //       .AsNoTracking()
            //       .AsQueryable()
            //       .ToListAsync();

            return _context.database.GetCollection<Course>("Course") as IEnumerable<Course>;
                
        }

    }
}
