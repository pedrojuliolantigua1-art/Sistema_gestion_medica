using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Models
{
    public class People
    {
        public int Id { get; set; }
        public string cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}"; 
    }
}
