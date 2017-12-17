using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public interface IRepository<T> 
    {
        List<T> Data { get; }
        IEnumerable<T> FindAll(Predicate<T> predicate);
    }
}
