﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio54
{
    public class MiException:Exception
    {
        public MiException(string mensaje, Exception inner) : base(mensaje, inner) { }
        public MiException(string mensaje) : base(mensaje) { }
    }
}
