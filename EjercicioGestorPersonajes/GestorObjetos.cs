using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal static class GestorObjetos
    {
        // Atributos
        private static List<Objeto> objetos;
        // Parametros
        public static List<Objeto> Objetos
        {
            get { return objetos; }
            set { objetos = value; }
        }
    }
}
