using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Autores
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Nacionalidad { get; set; }

        [NotMapped]
        public ICollection<LibrosAutores>? LibrosAutores { get; set; }
    }
}
