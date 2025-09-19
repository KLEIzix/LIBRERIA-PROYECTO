using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class SancionesPrueba
    {
        public static Sanciones Crear()
        {
            var entidad = new Sanciones();
            entidad.Usuario = 1;
            entidad.Descripcion = "Sanción de prueba por retraso";
            entidad.Fecha_Inicio = DateOnly.FromDateTime(DateTime.Now);
            entidad.Fecha_Fin = DateOnly.FromDateTime(DateTime.Now.AddDays(5));

            return entidad;
        }
    }
}
