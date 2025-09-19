using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class EstadosExistenciasPrueba
    {
        public static EstadosExistencias Crear()
        {
            var entidad = new EstadosExistencias();
            entidad.Nombre = "En uso";
            entidad.Descripcion = "Ejemplo de estado de existencia";

            return entidad;
        }
    }
}
