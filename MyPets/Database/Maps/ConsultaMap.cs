﻿using MyPets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MyPets.Database.Maps
{
    public class ConsultaMap: EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            ToTable("Consultas");

            HasKey(o => o.Id);
        }
    }
}