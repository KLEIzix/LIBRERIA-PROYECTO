using Dominio.Entidades;

namespace Ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Autores? Autores()
        {
            var entidad = new Autores();
            entidad.Nombre = "Autor Prueba";
            entidad.Nacionalidad = "Desconocida";

            return entidad;
        }

        public static Editoriales? Editoriales()
        {
            var entidad = new Editoriales();
            entidad.Nombre_Editorial = "Editorial Prueba";
            entidad.Sitio_Web = "www.prueba.com";

            return entidad;
        }

        public static Paises? Paises()
        {
            var entidad = new Paises();
            entidad.Nombre_Pais = "País Prueba";
            entidad.Region = "Región Prueba";

            return entidad;
        }

        public static Tipos? Tipos()
        {
            var entidad = new Tipos();
            entidad.Nombre_Tipo = "Tipo Prueba";

            return entidad;
        }

        public static Libros? Libros(Editoriales editoriales, Paises paises, Tipos tipos)
        {
            var entidad = new Libros();
            entidad.Titulo = "Libro Prueba";
            entidad.Edicion = "1ra";
            entidad.Fecha_Lanzamiento = DateOnly.FromDateTime(DateTime.Now);
            entidad.Editorial = editoriales.Id;
            entidad.Pais = paises.Id;
            entidad.Tipo = tipos.Id;

            // Generar ISBN único en cada llamada
            entidad.Isbn = $"ISBN-{Guid.NewGuid().ToString().Substring(0, 13)}";

            return entidad;
        }

        public static Existencias? Existencias(Libros libros)
        {
            var entidad = new Existencias();
            entidad.Libro = libros.Id;
            entidad.Ejemplares = 5;

            return entidad;
        }

        public static Estados? Estados()
        {
            var entidad = new Estados();
            entidad.Nombre_Estado = "Estado Prueba";

            return entidad;
        }


        public static EstadosExistencias? EstadosExistencias(Existencias existencias, Estados estados)
        {
            var entidad = new EstadosExistencias();
            entidad.Existencia = existencias.Id;
            entidad.Estado = estados.Id;
            entidad.Fecha_Cambio = DateTime.Now;

            return entidad;
        }

        public static Usuarios? Usuarios()
        {
            var entidad = new Usuarios();
            entidad.Nombre = "Usuario Prueba";

            // Documento único con Guid
            entidad.Documento = Guid.NewGuid().ToString().Substring(0, 10);

            entidad.Direccion = "Calle Prueba";
            entidad.Telefono = "3001234567";

            // Correo único con Guid
            entidad.Correo = $"usuario_{Guid.NewGuid().ToString().Substring(0, 8)}@prueba.com";

            entidad.Contraseña = "123456";
            entidad.Fecha_Nacimiento = DateOnly.FromDateTime(DateTime.Now.AddYears(-25));

            return entidad;
        }

        public static Prestamos? Prestamos(Usuarios usuarios, Existencias existencias, TiposPrestamos tiposPrestamos)
        {
            var entidad = new Prestamos();
            entidad.Usuario = usuarios.Id;
            entidad.Existencia = existencias.Id;
            entidad.Tipo_Prestamo = tiposPrestamos.Id;
            entidad.Fecha_Prestamo = DateOnly.FromDateTime(DateTime.Now);
            entidad.Fecha_Devolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(7));
            entidad.Fecha_Entrega_Real = null; // inicializamos en null hasta que se devuelva

            return entidad;
        }

        public static Sanciones? Sanciones(Usuarios usuarios)
        {
            var entidad = new Sanciones();
            entidad.Usuario = usuarios.Id;
            entidad.Descripcion = "Sanción de prueba";
            entidad.Fecha_Inicio = DateOnly.FromDateTime(DateTime.Now);
            entidad.Fecha_Fin = DateOnly.FromDateTime(DateTime.Now.AddDays(5));

            return entidad;
        }

        public static LibrosAutores? LibrosAutores(Libros libros, Autores autores)
        {
            var entidad = new LibrosAutores();
            entidad.Libro = libros.Id;
            entidad.Autor = autores.Id;

            return entidad;
        }

        public static Temas? Temas()
        {
            var entidad = new Temas();
            entidad.Nombre_Tema = "Tema Prueba";
            entidad.Area_Conocimiento = "Área Prueba";

            return entidad;
        }

        public static LibrosTemas? LibrosTemas(Libros libros, Temas temas)
        {
            var entidad = new LibrosTemas();
            entidad.Libro = libros.Id;
            entidad.Tema = temas.Id;

            return entidad;
        }

        public static TiposPrestamos? TiposPrestamos()
        {
            var entidad = new TiposPrestamos();
            entidad.Descripcion = "Préstamo Normal";

            return entidad;
        }
    }
}