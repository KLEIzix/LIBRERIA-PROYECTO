using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class TiposAplicacion : ITiposAplicacion
    {
        private IConexion? IConexion = null;

        public TiposAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Tipos? Guardar(Tipos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El tipo ya existe");

            this.IConexion!.Tipos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Tipos? Modificar(Tipos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tipo no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Tipos? Borrar(Tipos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tipo no existe en la base de datos");

            this.IConexion!.Tipos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Tipos> Listar()
        {
            return this.IConexion!.Tipos!.Take(20).ToList();
        }
    }
}
