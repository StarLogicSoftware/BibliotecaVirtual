using BibliotecaVirtual.Consola.Repositorio;
using BibliotecaVirtual.Consola.Modelos;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class LectorVista
    {
        public void CrearLector()
        {
            var repo1 = new RepoGenerico<Lector>();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();

            var lector = new Lector() { Nombre = nombre };

            repo1.Crear(lector);
        }

    }
}
