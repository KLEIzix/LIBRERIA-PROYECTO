using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Tipos
    {
        [Key]
        public int Id { get; set; }

        public string Nombre_Tipo { get; set; } = null!;

        [NotMapped]
        public ICollection<Libros>? Libros { get; set; }
    }
}
