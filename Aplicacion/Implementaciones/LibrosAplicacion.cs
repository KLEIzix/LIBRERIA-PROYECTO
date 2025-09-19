using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class LibrosAplicacion : ILibrosAplicacion
    {
        private IConexion? IConexion = null;

        public LibrosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Libros? Guardar(Libros? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El libro ya se encuentra registrado");

            this.IConexion!.Libros!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Libros? Modificar(Libros? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El libro no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Libros? Borrar(Libros? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El libro no existe en la base de datos");

            this.IConexion!.Libros!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Libros> Listar()
        {
            return this.IConexion!.Libros!.Take(20).ToList();
        }
    }
}
