using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Evaluación_Giovanni_Crescencio_Ahuactzi.Models
{
    public class Message
    {
        [Required]        
        public string UserName { get; set; }
        [Required]        
        public string message { get; set; }
    }
}