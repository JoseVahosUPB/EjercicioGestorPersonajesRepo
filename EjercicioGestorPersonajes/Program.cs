namespace EjercicioGestorPersonajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorObjetos.Setup();
            while (Menu.Principal()) { }
        }
    }
}
