using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class TiposPrestamosAplicacion : ITiposPrestamosAplicacion
    {
        private IConexion? IConexion = null;

        public TiposPrestamosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public TiposPrestamos? Guardar(TiposPrestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El tipo de préstamo ya existe");

            this.IConexion!.TiposPrestamos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public TiposPrestamos? Modificar(TiposPrestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tipo de préstamo no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public TiposPrestamos? Borrar(TiposPrestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tipo de préstamo no existe en la base de datos");

            this.IConexion!.TiposPrestamos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<TiposPrestamos> Listar()
        {
            return this.IConexion!.TiposPrestamos!.Take(20).ToList();
        }
    }
}
