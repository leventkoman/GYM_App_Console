using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Repository
{
    public interface IOperations<T>
    {
        IList<T> Listall();
        T Add(T model);
        bool DeleteIt(T model);
        IList<T> ListAlphabet();
    }
}
