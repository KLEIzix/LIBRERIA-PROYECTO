using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class LibrosAutoresAplicacion : ILibrosAutoresAplicacion
    {
        private IConexion? IConexion = null;

        public LibrosAutoresAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public LibrosAutores? Guardar(LibrosAutores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El registro ya existe");

            this.IConexion!.LibrosAutores!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public LibrosAutores? Modificar(LibrosAutores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El registro no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public LibrosAutores? Borrar(LibrosAutores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El registro no existe en la base de datos");

            this.IConexion!.LibrosAutores!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<LibrosAutores> Listar()
        {
            return this.IConexion!.LibrosAutores!.Take(20).ToList();
        }
    }
}
