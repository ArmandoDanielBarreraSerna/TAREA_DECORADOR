using TAREA_DECORADOR.Models;
using System;
using System.Collections.Generic;

namespace TAREA_DECORADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<iHelado>()
            {
                new Limon(new Mango(new Fresa(new Vaso()))),
                new LunetasDecorador(new Nuez(new Chocochips(new Chocolate(new Barquillo())))),
                new PlatanoDecorador(new Vainilla(new Fresa(new Canasta()))),
                new ChocolateLiquidoDecorador(new Fresa(new Vaso()))
            };

            foreach (var helado in menu)
            {
                Console.WriteLine($"{helado.ObtenerDescripcion()}..........${helado.ObtenerCosto()}");
            }
        }

    }
}
