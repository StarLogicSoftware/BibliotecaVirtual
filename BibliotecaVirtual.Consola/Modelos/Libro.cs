

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Libro : BaseEntidad
    {
        public string Titulo { get; set; }

        public List<Prestamo> Lectores { get; set; }
    }
}