using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public class Chocochips : SaboresDecorador
    {
        public Chocochips(iHelado helado) : base(helado)
        {

            _nombre = "bola sabor chocochips";
            _precio = 8.00;
        }
    }
}
