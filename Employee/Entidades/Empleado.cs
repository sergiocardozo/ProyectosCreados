using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        protected int EmpleadoId { get; set; }

        public int EmpleadoAños { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoPosicion { get; set; }
    }
}
