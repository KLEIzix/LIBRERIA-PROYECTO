﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Estados
    {
        [Key] public int Id { get; set; }

        public string? Nombre_Estado { get; set; }

        public string? Descripcion { get; set; }

        [NotMapped]
        public ICollection<EstadosExistencias>? EstadosExistencias { get; set; }
    }
}
