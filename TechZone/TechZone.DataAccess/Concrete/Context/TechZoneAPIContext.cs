using System;
using Microsoft.EntityFrameworkCore;
using TechZone.DataAccess.Concrete.EntityFramework.Mapping;
using TechZone.Entities.Concrete;
using TechZone.Entities.Dtos.UserDto;

namespace TechZone.DataAccess.Concrete.Context;

public class TechZoneAPIContext : DbContext
{
    public TechZoneAPIContext(DbContextOptions<TechZoneAPIContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMap());
    }

    public virtual DbSet<User> Users { get; set; }

}
