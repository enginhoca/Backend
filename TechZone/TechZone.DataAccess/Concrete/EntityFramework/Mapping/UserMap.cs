using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechZone.Entities.Concrete;

namespace TechZone.DataAccess.Concrete.EntityFramework.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users",@"dbo");
        builder.HasKey(x => x.Id);

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

        builder.Property(x => x.gender)
       .HasColumnName("gender")
       .IsRequired();

        builder.Property(x => x.DateOfBirth)
        .HasColumnName("DateOfBirth")
        .IsRequired();

        builder.Property(x=> x.CreatedDate).HasDefaultValue(DateTime.Now);

        builder.HasData(new User{
            
            Id =1,
            FirstName = "Mirac",
            LastName = "Yenice",
            gender = true,
            Password = "1357911a",
            DateOfBirth = Convert.ToDateTime("01-04-2000"),
            CreatedDate = DateTime.Now,
            Adress = "Istanbul",
            CreatedUserId = 1,
            UserName = "Admin",
            Email = "mrcinfoadmn@gmail.com"
        });




            




    }
}
