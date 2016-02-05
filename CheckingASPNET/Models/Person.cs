using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckingASPNET.Models
{
    public class Person
    {
        public int IdPerson { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}