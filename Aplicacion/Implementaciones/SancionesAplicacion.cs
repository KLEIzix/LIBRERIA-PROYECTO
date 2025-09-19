using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class SancionesAplicacion : ISancionesAplicacion
    {
        private IConexion? IConexion = null;

        public SancionesAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Sanciones? Guardar(Sanciones? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("La sanción ya existe");

            this.IConexion!.Sanciones!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Sanciones? Modificar(Sanciones? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("La sanción no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Sanciones? Borrar(Sanciones? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("La sanción no existe en la base de datos");

            this.IConexion!.Sanciones!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Sanciones> Listar()
        {
            return this.IConexion!.Sanciones!.Take(20).ToList();
        }
    }
}
