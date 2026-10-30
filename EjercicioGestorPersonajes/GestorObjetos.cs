using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal static class GestorObjetos
    {
        // Atributos
        private static List<Objeto> objetos = new List<Objeto>();
        // Parametros
        public static List<Objeto> Objetos
        {
            get { return objetos; }
            set { objetos = value; }
        }
        // Métodos
        public static void Setup() // Es lo primero que se llama en Main(). Instancia los objetos que pueden tener los personajes
        {
            objetos.Add(new Objeto("Croasan", 888));
            objetos.Add(new Objeto("Espada laser", 50));
            objetos.Add(new Objeto("Pistola de estrellas", 150));
            objetos.Add(new Objeto("Laxante", 9));
            objetos.Add(new Objeto("Awa de uwu", 999));
            objetos.Add(new Objeto("Comida sospechosa", 2));
            objetos.Add(new Objeto("Lentes de contacto", 1));
            objetos.Add(new Objeto("Una armadura", 11));
        }
    }
}
