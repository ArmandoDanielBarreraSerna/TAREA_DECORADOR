
using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Vaso : iHelado
    {
        public double ObtenerCosto()
        {
            return 0.00;
        }

        public string ObtenerDescripcion()
        {
            return "Helado en vaso";
        }
    }
}
