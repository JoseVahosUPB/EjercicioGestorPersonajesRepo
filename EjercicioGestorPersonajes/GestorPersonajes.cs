using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal static class GestorPersonajes
    {
        // Atributos
        private static List<Personaje> personajes;
        // Propiedades
        public static List<Personaje> Personajes
        {
            get { return personajes; }
            set { personajes = value; }
        }
        // Métodos
        public static void ConsultarPersonajes() // Muestra la información de cada personaje
        {

        }
    }
}
