using System;
using System.IO.Compression;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Concrete.EntityFramework.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.UserName)
               .HasColumnName("UserName")
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(x => x.FirstName)
       .HasColumnName("firstName")
       .HasMaxLength(50)
       .IsRequired();

        builder.Property(x => x.LastName)
        .HasColumnName("LastName")
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(x => x.Password)
            .HasColumnName("Password")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Gender)
       .HasColumnName("Gender")
       .IsRequired();

        builder.Property(x => x.DateOfBirth)
        .HasColumnName("DateOfBirth")
        .IsRequired();

        builder.Property(x=> x.CreatedDate).HasDefaultValue(DateTime.Now);

        builder.HasData(new User{
            
            Id =1,
            FirstName = "Mirac",
            LastName = "Yenice",
            Gender = true,
            Password = "1357911a",
            DateOfBirth = Convert.ToDateTime("2000-04-01"),
            CreatedDate = DateTime.Now,
            Adress = "Istanbul",
            CreatedUserId = 1,
            UserName = "Admin",
            Email = "mrcinfoadmn@gmail.com"
        });




            




    }
}
