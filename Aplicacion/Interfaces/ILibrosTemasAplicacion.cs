using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface ILibrosTemasAplicacion
    {
        void Configurar(string StringConexion);

        List<LibrosTemas> Listar();
        LibrosTemas? Guardar(LibrosTemas? entidad);
        LibrosTemas? Modificar(LibrosTemas? entidad);
        LibrosTemas? Borrar(LibrosTemas? entidad);
    }
}
