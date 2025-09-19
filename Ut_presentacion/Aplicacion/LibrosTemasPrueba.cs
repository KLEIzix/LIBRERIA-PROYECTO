using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class LibrosTemasPrueba
    {
        public static LibrosTemas Crear()
        {
            var entidad = new LibrosTemas();
            entidad.Libro = 1;
            entidad.Tema = 1;

            return entidad;
        }
    }
}
