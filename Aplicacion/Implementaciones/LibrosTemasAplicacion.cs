using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class LibrosTemasAplicacion : ILibrosTemasAplicacion
    {
        private IConexion? IConexion = null;

        public LibrosTemasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public LibrosTemas? Guardar(LibrosTemas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El registro ya existe");

            this.IConexion!.LibrosTemas!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public LibrosTemas? Modificar(LibrosTemas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El registro no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public LibrosTemas? Borrar(LibrosTemas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El registro no existe en la base de datos");

            this.IConexion!.LibrosTemas!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<LibrosTemas> Listar()
        {
            return this.IConexion!.LibrosTemas!.Take(20).ToList();
        }
    }
}
