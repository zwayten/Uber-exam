using GP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Data.Configurations
{
    public class VoitureConfiguration : IEntityTypeConfiguration<Voiture>
    {
        public void Configure(EntityTypeBuilder<Voiture> builder)
        {
            

            // Configurer la cle etrangere
            builder.HasMany<Chauffeur>(f => f.Chauffeurs)
                .WithOne(p => p.voiture);





        }
    }
}
