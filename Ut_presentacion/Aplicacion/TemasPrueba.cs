using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class TemasPrueba
    {
        public static Temas Crear()
        {
            var entidad = new Temas();
            entidad.Nombre_Tema = "Ciencia Ficción";
            entidad.Area_Conocimiento = "Literatura";

            return entidad;
        }
    }
}
