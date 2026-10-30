using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal static class Menu
    {
        // Métodos
        public static bool Principal()
        {
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("[1] Crear un personaje");
            Console.WriteLine("[2] Modificar un personaje");
            Console.WriteLine("[3] Consultar las características de un personaje");
            Console.WriteLine("[4] Consultar las características de todos los personajes");
            Console.WriteLine("[5] Agregar un objeto a un personaje");
            Console.WriteLine("[6] Quitarle un objeto a un personaje");
            Console.WriteLine("[X] Salir del programa");
            return Opciones.Principal();
        }
        // Clases anidadas
        private static class Formulario
        {
            // Métodos
            public static void CrearPersonaje()
            {

            }
            public static void ModificarPersonaje()
            {

            }
            public static void ConsultarPersonaje()
            {

            }
            public static void AgregarObjeto()
            {

            }
            public static void RetirarObjeto()
            {

            }
        }
        private static class Opciones
        {
            // Métodos
            public static bool Principal()
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        
                        break;

                    default:
                        break;
                }
                return true;
            }
        }
    }
}
