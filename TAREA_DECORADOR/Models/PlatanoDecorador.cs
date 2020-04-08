using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class PlatanoDecorador : HeladoDecorador
    {
        public PlatanoDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de platano";
            _precio = 5.00;
        }
    }
}
