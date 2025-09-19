using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface ITiposPrestamosAplicacion
    {
        void Configurar(string StringConexion);

        List<TiposPrestamos> Listar();
        TiposPrestamos? Guardar(TiposPrestamos? entidad);
        TiposPrestamos? Modificar(TiposPrestamos? entidad);
        TiposPrestamos? Borrar(TiposPrestamos? entidad);
    }
}
