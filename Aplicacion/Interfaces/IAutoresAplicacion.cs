using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface IAutoresAplicacion
    {
        void Configurar(string StringConexion);

        List<Autores> Listar();
        Autores? Guardar(Autores? entidad);
        Autores? Modificar(Autores? entidad);
        Autores? Borrar(Autores? entidad);
    }
}
