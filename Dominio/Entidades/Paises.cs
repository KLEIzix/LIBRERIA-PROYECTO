using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Paises
    {
        [Key] public int Id { get; set; }

        public string Nombre_Pais { get; set; } = null!;
        public string? Region { get; set; }

        [NotMapped]
        public ICollection<Libros>? Libros { get; set; }
    }
}
