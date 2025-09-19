using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface IExistenciasAplicacion
    {
        void Configurar(string StringConexion);

        List<Existencias> Listar();
        Existencias? Guardar(Existencias? entidad);
        Existencias? Modificar(Existencias? entidad);
        Existencias? Borrar(Existencias? entidad);
    }
}
