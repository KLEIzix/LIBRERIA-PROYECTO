using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface ISancionesAplicacion
    {
        void Configurar(string StringConexion);

        List<Sanciones> Listar();
        Sanciones? Guardar(Sanciones? entidad);
        Sanciones? Modificar(Sanciones? entidad);
        Sanciones? Borrar(Sanciones? entidad);
    }
}
