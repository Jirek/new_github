using MyPets.Database.Maps;
using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPets.Database
{
    public class DbEntities: DbContext
    {
        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<Propietario> Propietarios { get; set; }
        public IDbSet<Mascota> Mascotas { get; set; }
        public IDbSet<Consulta> Consultas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new PropietarioMap());
            modelBuilder.Configurations.Add(new MascotaMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
        
        }
    }
}