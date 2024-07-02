

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Lector : BaseEntidad
    {
        public Lector()
        {
            Libros = new List<Prestamo>();
        }
        public string Nombre { get; set; }
        public List<Prestamo> Libros { get; set; }
    }
}

