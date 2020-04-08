using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA_DECORADOR.Models
{
    public abstract class SaboresDecorador : iHelado
    {
        private iHelado _helado;
        protected string _nombre = "Sin definir";
        protected double _precio = 0.00;


        public SaboresDecorador(iHelado helado)
        {
            _helado = helado;
        }
        public double ObtenerCosto()
        {
            return _helado.ObtenerCosto() + _precio;
        }

        public string ObtenerDescripcion()
        {
            return $"{_helado.ObtenerDescripcion()}, {_nombre}";
        }
    }
}
