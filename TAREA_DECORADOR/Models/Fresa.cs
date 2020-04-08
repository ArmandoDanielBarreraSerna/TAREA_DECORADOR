using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Fresa : SaboresDecorador
    {
        public Fresa(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor fresa";
            _precio = 5.00;
        }
    }
}
