namespace pFmarc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Juego elJuego = new Juego();
            elJuego.Iniciar();
            flot flotusaario = new flot();
            flotusaario.CrearFlotaAutomatica();
            foreach (var item in flotusaario.Barcos  )
            {
                System.Console.WriteLine(item.Nombre);
            }
        }
    }
}