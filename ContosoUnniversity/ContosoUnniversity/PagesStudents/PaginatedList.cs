using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUnniversity.PagesStudents
{
    public class PaginatedList<T>
    {
        public static implicit operator PaginatedList<T>(List<Student> v)
        {
            throw new NotImplementedException();
        }

        internal static Task<PaginatedList<Student>> CreateAsync(IQueryable<Student> queryable, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}