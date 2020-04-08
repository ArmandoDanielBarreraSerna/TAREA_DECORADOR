using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Vainilla : SaboresDecorador
    {
        public Vainilla(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor vainilla";
            _precio = 7.00;
        }
    }
}
