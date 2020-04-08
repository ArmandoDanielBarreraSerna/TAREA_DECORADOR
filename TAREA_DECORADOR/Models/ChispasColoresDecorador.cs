using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class ChispasColoresDecorador : HeladoDecorador
    {
        public ChispasColoresDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de chispas de colores";
            _precio = 0.50;
        }
    }
}
