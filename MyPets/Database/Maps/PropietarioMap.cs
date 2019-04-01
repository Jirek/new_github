using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MyPets.Database.Maps
{
    public class PropietarioMap: EntityTypeConfiguration<Propietario>
    {
        public PropietarioMap()
        {
            ToTable("Propietarios");

            HasKey(o => o.Id);

            HasMany(o => o.Mascotas)
                .WithRequired(o => o.Propietario)
                .HasForeignKey(o => o.PropietarioId);     
        }
    }
}