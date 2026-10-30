using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal class Objeto
    {
        // Atributos
        private string nombre;
        private int valor;
        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        // Constructores
        public Objeto(string nombre, int valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
