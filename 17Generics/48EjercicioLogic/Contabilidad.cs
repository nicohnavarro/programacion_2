using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48EjercicioLogic
{
    public class Contabilidad<T,U> where T:Documento where U:Documento,new()
    {
        public List<T> egresos;
        public List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator+(Contabilidad<T,U> c,T egresos)
        {
            c.egresos.Add(egresos);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingresos)
        {
            c.ingresos.Add(ingresos);
            return c;
        }
    }
}
