using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPets.Models
{
    public class Mascota
    {
        public Mascota()
        {
            Consultas = new List<Consulta>();
        }

        public int Id {get;set; }
        public string Nombre {get;set; }
        public DateTime? FechaNacimiento {get;set; }
        public string Sexo {get;set; }
        public decimal Peso {get;set; }
        public string Especio {get;set; }
        public string Raza {get;set; }

        public int PropietarioId { get; set; }
        public Propietario Propietario { get; set; }

        public List<Consulta> Consultas { get;set; }
    }
}