using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Editoriales
    {
        [Key]
        public int Id { get; set; }

        public string Nombre_Editorial { get; set; } = null!;

        public string? Sitio_Web { get; set; }

        [NotMapped]
        public ICollection<Libros>? Libros { get; set; }
    }
}
