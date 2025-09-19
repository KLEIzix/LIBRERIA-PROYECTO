using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class ExistenciasPrueba
    {
        public static Existencias Crear()
        {
            var entidad = new Existencias();
            entidad.Codigo_Barras = "EXIST-0001";
            entidad.Fecha_Ingreso = DateOnly.FromDateTime(DateTime.Now);

            return entidad;
        }
    }
}
