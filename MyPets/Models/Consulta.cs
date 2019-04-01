using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPets.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime FechaConsulta { get;set; }
        public string Anamnesis {get;set; }
        public string Examen {get;set; }
        public string Diagnostico {get;set; }
        public string Tratamiento {get;set; }

        public int MascotaId {get;set; }
        public Mascota Mascota {get;set; }
    }
}