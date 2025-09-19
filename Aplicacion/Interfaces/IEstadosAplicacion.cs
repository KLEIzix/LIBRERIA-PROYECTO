using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface IEstadosAplicacion
    {
        void Configurar(string StringConexion);

        List<Estados> Listar();
        Estados? Guardar(Estados? entidad);
        Estados? Modificar(Estados? entidad);
        Estados? Borrar(Estados? entidad);
    }
}
