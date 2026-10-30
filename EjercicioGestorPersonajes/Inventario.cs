using System;
using System.Collections.Generic;
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
        public void AgregarObjeto(Objeto objeto)
        {

        }
        public void RetirarObjeto(Objeto objeto)
        {

        }
        public void CalcularValorTotal()
        {

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
