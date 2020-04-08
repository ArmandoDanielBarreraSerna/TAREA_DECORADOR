using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Mango : SaboresDecorador
    {
        public Mango(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor mango";
            _precio = 6.00;
        }
    }
}
