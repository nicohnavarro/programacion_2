using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        void Guardar(string tabla,T datos);
        void Leer(string tabla, out T datos);
    }
}
