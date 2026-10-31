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
            Console.Clear();
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
                // Variables locales
                Personaje nuevoPersonaje;
                string nombre;
                float vida;
                int nivel;
                // Ingreso de datos
                Console.WriteLine("¿Cómo va a llamar a su nuevo personaje?");
                nombre = Console.ReadLine();
                Console.WriteLine("¿Cuanta vida va a tener?");
                vida = float.Parse(Console.ReadLine());
                Console.WriteLine("¿Con qué nivel va a comenzar?");
                nivel = int.Parse(Console.ReadLine());
                // Salida
                nuevoPersonaje = new Personaje(nombre, vida, nivel);
                GestorPersonajes.Personajes.Add(nuevoPersonaje);
                Console.WriteLine("El personaje se creó exitosamente");
                Console.ReadKey();
            }
            public static void ModificarPersonaje()
            {
                // Variables locales
                Personaje personaje;
                string nombre;
                float vida;
                int nivel;
                // Ingreso de datos
                Console.WriteLine("Ingrese el nombre actual del personaje que va a modificar");
                personaje = GestorPersonajes.GetPersonaje(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre del personaje");
                nombre = Console.ReadLine();
                Console.WriteLine("¿Cuanta vida va a tener?");
                vida = float.Parse(Console.ReadLine());
                Console.WriteLine("¿Con qué nivel va a comenzar?");
                nivel = int.Parse(Console.ReadLine());
                // Salida
                personaje.ModificarPersonaje(nombre, vida, nivel);
                Console.WriteLine("El personaje ha sido modificado exitosamente");
                Console.ReadKey();
            }
            public static void ConsultarPersonaje()
            {
                // Variables locales
                Personaje personaje;
                // Ingreso de datos
                Console.WriteLine("Ingrese el nombre del personaje que va a consultar");
                personaje = GestorPersonajes.GetPersonaje(Console.ReadLine());
                // Salida
                Console.WriteLine("Las características de su personaje son:");
                personaje.ConsultarCaracteristicas();
                Console.ReadKey();
            }
            public static void AgregarObjeto()
            {
                // Variables locales
                Personaje personaje;
                Objeto objeto;
                // Ingreso de datos
                Console.WriteLine("Ingrese el nombre del personaje al que le va a dar el objeto");
                personaje = GestorPersonajes.GetPersonaje(Console.ReadLine());
                GestorObjetos.MostrarObjetos();
                Console.WriteLine("Ingrese el nombre del objeto que le va a dar al personaje");
                objeto = GestorObjetos.GetObjeto(Console.ReadLine());
                // Salida
                personaje.Inventario.AgregarObjeto(objeto);
                Console.WriteLine("Objeto agregado exitosamente");
                Console.ReadKey();
            }
            public static void RetirarObjeto()
            {
                // Variables locales
                Personaje personaje;
                Objeto objeto;
                // Ingreso de datos
                Console.WriteLine("Ingrese el nombre del personaje al que le va a quitar el objeto");
                personaje = GestorPersonajes.GetPersonaje(Console.ReadLine());
                Console.WriteLine("Estos son los objetos que tiene el personaje");
                personaje.Inventario.ConsultarInventario();
                Console.WriteLine("Ingrese el nombre del objeto que le va a quitar");
                objeto = GestorObjetos.GetObjeto(Console.ReadLine());
                // Salida
                personaje.Inventario.RetirarObjeto(objeto);
                Console.WriteLine("Objeto quitado exitosamente");
                Console.ReadKey();
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
                        Formulario.CrearPersonaje();
                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        Formulario.ModificarPersonaje();
                        break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        Formulario.ConsultarPersonaje();
                        break;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:
                        GestorPersonajes.ConsultarPersonajes();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5 or ConsoleKey.NumPad5:
                        Formulario.AgregarObjeto();
                        break;
                    case ConsoleKey.D6 or ConsoleKey.NumPad6:
                        Formulario.RetirarObjeto();
                        break;
                    case ConsoleKey.X:
                        return false;
                    default:
                        break;
                }
                return true;
            }
        }
    }
}
