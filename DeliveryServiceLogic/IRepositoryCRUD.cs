using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceLogic
{
    public interface IRepositoryCRUD<T> : IRepository<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);
    }
}
