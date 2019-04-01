using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MyPets.Database.Maps
{
    public class MascotaMap: EntityTypeConfiguration<Mascota>
    {
        public MascotaMap()
        {
            ToTable("Mascotas");

            HasKey(o => o.Id);
            
            HasMany(o => o.Consultas)
                .WithRequired(o => o.Mascota)
                .HasForeignKey(o => o.MascotaId);            
        }
    }
}