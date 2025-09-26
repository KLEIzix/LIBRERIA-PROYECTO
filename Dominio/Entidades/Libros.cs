using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Libros
    {
        [Key]
        public int Id { get; set; }

        public int? Editorial { get; set; }
        public int? Pais { get; set; }
        public int? Tipo { get; set; }
        public string? Isbn { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Edicion { get; set; }
        public DateOnly? Fecha_Lanzamiento { get; set; }

        [ForeignKey("Editorial")]
        public Editoriales? EditorialNavigation { get; set; }

        [NotMapped]
        public ICollection<Existencias>? Existencia { get; set; }

        [NotMapped]
        public ICollection<LibrosAutores>? LibrosAutores { get; set; }

        [NotMapped]
        public ICollection<LibrosTemas>? LibrosTemas { get; set; }

        [ForeignKey("Pais")]
        public Paises? PaisNavigation { get; set; }

        [ForeignKey("Tipo")]
        public Tipos? TipoNavigation { get; set; }
    }
}
