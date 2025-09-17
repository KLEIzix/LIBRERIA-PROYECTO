using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Sanciones
    {
        [Key] public int Id { get; set; }

        public int? Usuario { get; set; }
        public string? Descripcion { get; set; }
        public DateOnly? Fecha_Inicio { get; set; }
        public DateOnly? Fecha_Fin { get; set; }

        [ForeignKey("Usuario")]
        public Usuarios? UsuarioNavigation { get; set; }
    }
}
