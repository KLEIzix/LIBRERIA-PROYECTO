using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class LibrosAutoresPrueba
    {
        public static LibrosAutores Crear()
        {
            var entidad = new LibrosAutores();
            entidad.Libro = 1;
            entidad.Autor = 1;

            return entidad;
        }
    }
}
