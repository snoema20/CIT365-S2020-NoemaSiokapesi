using ContosoUniversity.Models;
using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class DbSet<T>
    {
        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        internal bool Any()
        {
            throw new NotImplementedException();
        }

        internal bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal void Add(Enrollment e)
        {
            throw new NotImplementedException();
        }

        internal void Add(Student s)
        {
            throw new NotImplementedException();
        }

        internal void Add(Course c)
        {
            throw new NotImplementedException();
        }
    }
}