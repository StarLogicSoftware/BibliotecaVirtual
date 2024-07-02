

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Prestamo
    {
        public int LectorId { get; set; }
        public Lector Lector { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

    }
}
