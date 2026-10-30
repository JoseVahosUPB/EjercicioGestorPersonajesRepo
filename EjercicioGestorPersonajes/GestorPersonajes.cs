using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal static class GestorPersonajes
    {
        // Atributos
        private static List<Personaje> personajes = new List<Personaje>();
        // Propiedades
        public static List<Personaje> Personajes
        {
            get { return personajes; }
            set { personajes = value; }
        }
        // Métodos
        public static void ConsultarPersonajes() // Muestra la información de cada personaje
        {
            foreach (Personaje personaje in personajes)
            {
                personaje.ConsultarCaracteristicas();
                Console.WriteLine();
            }
        }
        public static Personaje? GetPersonaje(string nombre) // Devuelve un personaje según su nombre
        {
            foreach (Personaje personaje in personajes)
            {
                if (personaje.Nombre == nombre)
                {
                    return personaje;
                }
            }
            return null;
        }
    }
}
