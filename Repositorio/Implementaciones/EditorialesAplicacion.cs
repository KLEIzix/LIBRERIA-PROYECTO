using Dominio.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Implementaciones
{
    public class EditorialesAplicacion : IEditorialesAplicacion
    {
        private string? _stringConexion;

        public void Configurar(string StringConexion)
        {
            _stringConexion = StringConexion;
           
        }

        public List<Editorieales> PorEstudiante(Editorieales? entidad)
        {
            return new List<Editorieales>();
        }

        public List<Editorieales> Listar()
        {
           
            return new List<Editorieales>();
        }

        public Editorieales? Guardar(Editorieales? entidad)
        {
            
            return entidad;
        }

        public Editorieales? Modificar(Editorieales? entidad)
        {
          
            return entidad;
        }

        public Editorieales? Borrar(Editorieales? entidad)
        {
          
            return entidad;
        }
    }
}
