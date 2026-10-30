using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal class Personaje
    {
        // Atributos
        private string nombre;
        private float vida;
        private int nivel;
        private Inventario inventario;
        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public Inventario Inventario
        {
            get { return inventario; }
            set { inventario = value; }
        }
        // Constructores
        public Personaje(string nombre, float vida, int nivel)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.nivel = nivel;
            this.inventario = new Inventario();
        }
        // Métodos
        public void ConsultarCaracteristicas() // Muestra la información del personaje
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Nivel: {nivel}");
            inventario.ConsultarInventario();

        }
        public void ModificarPersonajes()
        {

        }
    }
}
