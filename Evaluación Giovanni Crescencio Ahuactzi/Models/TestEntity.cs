﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Evaluación_Giovanni_Crescencio_Ahuactzi.Models
{
    public class TestEntity
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(30)]
        public string Apellido { get; set; }
    }
}