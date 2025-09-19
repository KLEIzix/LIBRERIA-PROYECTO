using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class EstadosPrueba
    {
        public static Estados Crear()
        {
            var entidad = new Estados();
            entidad.Nombre_Estado = "Disponible";
            entidad.Descripcion = "Estado de prueba para libros";

            return entidad;
        }
    }
}
