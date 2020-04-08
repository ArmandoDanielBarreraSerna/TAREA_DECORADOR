using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class ChocolateLiquidoDecorador : HeladoDecorador
    {
        public ChocolateLiquidoDecorador(iHelado helado) : base(helado)
        {

            _nombre = "topping de chocolate Liquido";
            _precio = 0.00;
        }
    }
}
