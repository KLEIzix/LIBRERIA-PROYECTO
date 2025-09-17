using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuarios
    {
        [Key] public int Id { get; set; }

        public string Nombre { get; set; } = null!;
        public string? Documento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string Contraseña { get; set; } = null!;
        public DateOnly? Fecha_Nacimiento { get; set; }

        [NotMapped]
        public ICollection<Prestamos>? Prestamos { get; set; }

        [NotMapped]
        public ICollection<Sanciones>? Sanciones { get; set; }
    }
}
