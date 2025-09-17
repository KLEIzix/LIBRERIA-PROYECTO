using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Prestamos
    {
        [Key] public int Id { get; set; }

        public int? Usuario { get; set; }
        public int? Tipo_Prestamo { get; set; }
        public int? Existencia { get; set; }

        public DateOnly Fecha_Prestamo { get; set; }
        public DateOnly? Fecha_Devolucion { get; set; }
        public DateOnly? Fecha_Entrega_Real { get; set; }

        [ForeignKey("Existencia")]
        public Existencias? ExistenciaNavigation { get; set; }

        [ForeignKey("TipoPrestamo")]
        public TiposPrestamos? TipoPrestamoNavigation { get; set; }

        [ForeignKey("Usuario")]
        public Usuarios? UsuarioNavigation { get; set; }
    }
}
