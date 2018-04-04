using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Business.Logic.Interfaces
{
    interface ICrudBL<T> // where T : VuelingModelObject
    {
        T Add(T entity);
        T Modify(T entity);
        List<T> GetAll();

    }
}
