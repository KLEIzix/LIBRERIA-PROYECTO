using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class LibrosAutores
    {
        [Key] public int Id { get; set; }

        public int? Libro { get; set; }
        public int? Autor { get; set; }

        [ForeignKey("Autor")]
        public Autores? AutorNavigation { get; set; }

        [ForeignKey("Libro")]
        public Libros? LibroNavigation { get; set; }
    }
}
