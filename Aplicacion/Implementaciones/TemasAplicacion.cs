using Dominio.Entidades;
using Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Implementaciones
{
    public class TemasAplicacion : ITemasAplicacion
    {
        private IConexion? IConexion = null;

        public TemasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Temas? Guardar(Temas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id != 0) throw new Exception("El tema ya existe");

            this.IConexion!.Temas!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Temas? Modificar(Temas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tema no existe en la base de datos");

            var entry = this.IConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Temas? Borrar(Temas? entidad)
        {
            if (entidad == null) throw new Exception("Falta información");
            if (entidad.Id == 0) throw new Exception("El tema no existe en la base de datos");

            this.IConexion!.Temas!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Temas> Listar()
        {
            return this.IConexion!.Temas!.Take(20).ToList();
        }
    }
}
