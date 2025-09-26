using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Temas
    {
        [Key]
        public int Id { get; set; }

        public string Nombre_Tema { get; set; } = null!;
        public string? Area_Conocimiento { get; set; }

        [NotMapped]
        public ICollection<LibrosTemas>? LibrosTemas { get; set; }
    }
}
