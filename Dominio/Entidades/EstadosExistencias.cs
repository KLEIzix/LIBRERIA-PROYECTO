using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EstadosExistencias
    {
        [Key] public int Id { get; set; }

        public int? Existencia { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fecha_Cambio { get; set; }
        
        public String? Nombre_Existencias { get; set; }

        public String? Descripcion { get; set; }

        [ForeignKey("Estado")]
        public Estados? EstadoNavigation { get; set; }

        [ForeignKey("Existencia")]
        public Existencias? ExistenciaNavigation { get; set; }
    }
}
