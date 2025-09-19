using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class PrestamosPrueba
    {
        public static Prestamos Crear()
        {
            var entidad = new Prestamos();
            entidad.Usuario = 1;
            entidad.Tipo_Prestamo = 1;
            entidad.Existencia = 1;
            entidad.Fecha_Prestamo = DateOnly.FromDateTime(DateTime.Now);
            entidad.Fecha_Devolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(7));

            return entidad;
        }
    }
}
