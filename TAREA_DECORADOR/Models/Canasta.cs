using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Canasta : iHelado
    {
        public double ObtenerCosto()
        {
            return 1.00;
        }

        public string ObtenerDescripcion()
        {
            return "Helado en canasta";
        }
    }
}
