using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class FresasDecorador : HeladoDecorador
    {
        public FresasDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de fresas";
            _precio = 7.00;
        }
    }
}
