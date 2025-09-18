using Dominio.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Implementaciones
{
    public class AutoresAplicacion : IAutoresAplicacion
    {
        private string? _stringConexion;

        public void Configurar(string StringConexion)
        {
            _stringConexion = StringConexion;
    
        }

        public List<Autores> PorEstudiante(Autores? entidad)
        {
        
            return new List<Autores>();
        }

        public List<Autores> Listar()
        {
   
            return new List<Autores>();
        }

        public Autores? Guardar(Autores? entidad)
        {
      
            return entidad;
        }

        public Autores? Modificar(Autores? entidad)
        {

            return entidad;
        }

        public Autores? Borrar(Autores? entidad)
        {
  
            return entidad;
        }
    }
}
