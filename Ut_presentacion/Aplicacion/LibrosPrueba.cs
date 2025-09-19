using Dominio.Entidades;

namespace Ut_presentacion.Aplicacion
{
    public class LibrosPrueba
    {
        public static Libros Crear()
        {
            var entidad = new Libros();
            entidad.Titulo = "Libro de Prueba";
            entidad.ISBN = "978-1234567890";
            entidad.Publicacion = new DateOnly(2020, 1, 1);
            entidad.Paginas = 150;

            return entidad;
        }
    }
}
