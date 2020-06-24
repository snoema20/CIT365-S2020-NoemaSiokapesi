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

        internal bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}