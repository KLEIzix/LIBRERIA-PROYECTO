using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class AutoresAplicacion : IAutoresAplicacion
    {
        private IConexion? IConexion = null;

        public AutoresAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Autores? Guardar(Autores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El autor ya se encuentra registrado");

            this.IConexion!.Autores!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Autores? Modificar(Autores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El autor no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Autores? Borrar(Autores? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El autor no existe en la base de datos");

            this.IConexion!.Autores!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Autores> Listar()
        {
            return this.IConexion!.Autores!.Take(20).ToList();
        }
    }
}
