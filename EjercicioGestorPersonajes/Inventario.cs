using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EjercicioGestorPersonajes
{
    internal class Inventario
    {
        // Atributos
        private List<Objeto> objetos;
        // Propiedades
        private List<Objeto> Objetos
        {
            get { return objetos; }
            set { objetos = value; }
        }
        // Constructores
        public Inventario()
        {
            objetos = new List<Objeto>();
        }
        // Métodos
        public void AgregarObjeto(Objeto objeto) // Agrega un objeto al inventario
        {
            objetos.Add(objeto);
        }
        public void RetirarObjeto(Objeto objeto) // Remueve el objeto específicado del inventario
        {
            objetos.Remove(objeto);
        }
        public void CalcularValorTotal() // Calcula y muestra la suma de los valores de los objetos del inventario
        {
            int suma = 0;
            foreach (Objeto objeto in objetos)
            {
                suma += objeto.Valor;
            }
            Console.WriteLine($"Valor total: {suma}o");
        }
        public void ConsultarInventario() // Muestra cada uno de los objetos en el inventario
        {
            Console.WriteLine("Inventario:");
            foreach (Objeto objeto in objetos)
            {
                Console.WriteLine($"- {objeto.Nombre}: {objeto.Valor}o");
            }
        }
    }
}
