using GP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //le nom de la table au niveau de la BD

            builder.HasKey(f => new { f.VoitureId, f.ClientId, f.DateCourse });//clé primaire compose

            // Configurer la cle etrangere
            builder.HasOne<Voiture>(f => f.voiture)
                .WithMany(p => p.Courses);


            // Configurer la cle etrangere
            builder.HasOne<Client>(f => f.client)
           .WithMany(p => p.courses);



        }
    }
}
