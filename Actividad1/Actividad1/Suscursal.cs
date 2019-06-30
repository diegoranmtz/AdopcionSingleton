using System.Collections.Generic;

namespace Actividad1
{
    class Suscursal
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public List<Empleado> empleados { get; set; }
    }
}