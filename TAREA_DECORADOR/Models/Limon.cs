using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Limon : SaboresDecorador
    {
        public Limon(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor limon";
            _precio = 5.00;
        }
    }
}
