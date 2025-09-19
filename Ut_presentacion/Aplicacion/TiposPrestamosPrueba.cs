using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class TiposPrestamosPrueba
    {
        public static TiposPrestamos Crear()
        {
            var entidad = new TiposPrestamos();
            entidad.Descripcion = "Préstamo a domicilio";

            return entidad;
        }
    }
}
