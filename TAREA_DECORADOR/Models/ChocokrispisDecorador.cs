using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class ChocokrispisDecorador : HeladoDecorador
    {
        public ChocokrispisDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de chocokrispis";
            _precio = 0.50;
        }
    }
}
