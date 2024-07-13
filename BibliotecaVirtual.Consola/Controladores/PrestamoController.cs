﻿using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Consola.Respositorios;
using BibliotecaVirtual.Consola.Enumeraciones;

namespace BibliotecaVirtual.Consola.Controladores
{
    public class PrestamoController
    {
        public Prestamo PrestarLibro(Prestamo prestamo)
        {
            var repo = new RepositorioPRestamo();
            
            prestamo.FechaPrestamo = DateTime.Now;

            repo.Crear(prestamo);

            return prestamo;

        }

        public Prestamo DevolverLibro(Prestamo prestamo)
        {
            var repo = new RepositorioPRestamo();

            prestamo.Estado = EstadoPrestamoEnum.Finalizado;
            prestamo.FechaPrestamo = DateTime.Now;

            repo.Actualizar(prestamo);

            return prestamo;
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            var repo = new RepositorioPRestamo();

            var lista = repo.VerTodos();

            return lista;
        }
    }
}
