using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Chocolate : SaboresDecorador
    {
        public Chocolate(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor chocolate";
            _precio = 8.00;
        }
    }
}
