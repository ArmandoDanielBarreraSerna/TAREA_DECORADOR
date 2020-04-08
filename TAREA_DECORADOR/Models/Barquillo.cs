using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Barquillo : iHelado
    {
        public double ObtenerCosto()
        {
            return 0.50;
        }

        public string ObtenerDescripcion()
        {
            return "Helado en barquillo";
        }
    }
}
