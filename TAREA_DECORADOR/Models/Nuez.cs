using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Nuez : SaboresDecorador
    {
        public Nuez(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor nuez";
            _precio = 7.00;
        }
    }
}
