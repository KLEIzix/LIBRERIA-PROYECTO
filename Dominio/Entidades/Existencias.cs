using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Existencias
    {
        [Key] public int Id { get; set; }

        public int? Libro { get; set; }
        public int Ejemplares { get; set; }

        public DateOnly Fecha_Ingreso { get; set; }

        public string? Codigo_Barras { get; set; }

        [NotMapped]
        public ICollection<EstadosExistencias>? EstadosExistencia { get; set; }

        [ForeignKey("Libro")]
        public Libros? LibroNavigation { get; set; }

        [NotMapped]
        public ICollection<Prestamos>? Prestamos { get; set; }
    }
}
