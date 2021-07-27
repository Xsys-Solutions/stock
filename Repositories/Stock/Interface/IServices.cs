using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Stock.Interface
{
    public interface IServices<T>
    {
        string[] Validation(T obj);
        T Create(T obj);
        T Update(T obj);
        T Delete(int id);
        T Get(int id);
        int Add(T obj);
        int Remove(int id);
    }
}
