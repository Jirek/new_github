using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPets.Models
{
    public class Propietario
    {
        public Propietario()
        {
            Mascotas = new List<Mascota>();
        }

        public int Id {get;set; }
        public string Nombre {get;set; }
        public string Telefono {get;set; }
        public string Email {get;set; }
        public string Direccion {get;set; }

        public List<Mascota> Mascotas { get;set; }

    }
}