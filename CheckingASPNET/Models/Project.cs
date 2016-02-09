using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckingASPNET.Models
{
    public class Project
    {
        [Key]
        public int IdProject { get; set; }

        [Display(Name ="Nombre de proyecto")]
        [Required]
        public string NombreProject { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }
    }
}