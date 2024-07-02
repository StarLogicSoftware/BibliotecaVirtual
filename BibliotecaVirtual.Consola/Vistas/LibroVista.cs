using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Consola.Repositorio;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class LibroVista
    {
        public void CrearLibro()
        {
            var repo = new RepoGenerico<Libro>();

            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine();

            var libro = new Libro() { Titulo = titulo };

            repo.Crear(libro);
        }

    }
}
