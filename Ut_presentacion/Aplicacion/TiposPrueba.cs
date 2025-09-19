using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class TiposPrueba
    {
        public static Tipos Crear()
        {
            var entidad = new Tipos();
            entidad.Nombre_Tipo = "Digital";

            return entidad;
        }
    }
}
