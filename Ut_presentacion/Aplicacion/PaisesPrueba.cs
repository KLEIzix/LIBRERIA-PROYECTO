using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class PaisesPrueba
    {
        public static Paises Crear()
        {
            var entidad = new Paises();
            entidad.Nombre_Pais = "Colombia";
            entidad.Region = "Latinoamérica";

            return entidad;
        }
    }
}
