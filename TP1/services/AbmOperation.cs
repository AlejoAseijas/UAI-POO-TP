using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.services
{
    public interface AbmOperation<T>
    {
        List<T> items { get; set; }

        void Alta(T obj);
        void Baja(T obj);
        void Modificar(T obj1, T obj2);

    }
}
