using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class LunetasDecorador : HeladoDecorador
    {
        public LunetasDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de lunetas";
            _precio = 0.70;
        }
    }
}
