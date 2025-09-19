using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface ITemasAplicacion
    {
        void Configurar(string StringConexion);

        List<Temas> Listar();
        Temas? Guardar(Temas? entidad);
        Temas? Modificar(Temas? entidad);
        Temas? Borrar(Temas? entidad);
    }
}
