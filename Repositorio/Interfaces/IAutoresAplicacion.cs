using Dominio.Entidades;

namespace Repositorios.Interfaces
{
    public interface IAutoresAplicacion
    {
        void Configurar(string StringConexion);

        List<Autores> PorEstudiante(Autores? entidad);

        List<Autores> Listar();

        Autores? Guardar(Autores? entidad);

        Autores? Modificar(Autores? entidad);

        Autores? Borrar(Autores? entidad);
    }
}
