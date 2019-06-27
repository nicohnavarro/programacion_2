using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidadException: Exception
    {
        public PatenteInvalidadException(string mensaje) : base(mensaje)
        { }
        public PatenteInvalidadException(string mensaje, Exception inner) : base(mensaje, inner)
        { }
    }
}
