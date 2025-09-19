using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class PrestamosAplicacion : IPrestamosAplicacion
    {
        private IConexion? IConexion = null;

        public PrestamosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Prestamos? Guardar(Prestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El préstamo ya existe");

            this.IConexion!.Prestamos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Prestamos? Modificar(Prestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El préstamo no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Prestamos? Borrar(Prestamos? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El préstamo no existe en la base de datos");

            this.IConexion!.Prestamos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Prestamos> Listar()
        {
            return this.IConexion!.Prestamos!.Take(20).ToList();
        }
    }
}
