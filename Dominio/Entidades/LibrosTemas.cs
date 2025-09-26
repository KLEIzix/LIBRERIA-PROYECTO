using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class LibrosTemas
    {
        [Key]
        public int Id { get; set; }

        public int? Libro { get; set; }
        public int? Tema { get; set; }

        [ForeignKey("Libro")]
        public Libros? LibroNavigation { get; set; }

        [ForeignKey("Tema")]
        public Temas? TemaNavigation { get; set; }
    }
}
