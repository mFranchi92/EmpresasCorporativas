using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICRUD<T>
    {
        bool Create(T Entidad);
        T Read(object ID);
        List<T> ReadAll();
        bool Update(T Entidad);
        bool Delete(T Entidad);
    }
}
