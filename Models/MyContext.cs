using Microsoft.EntityFrameworkCore;
using ActivitiesEvent.Models;
using System.Collections.Generic;

namespace ActivitiesEvent.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Users> TheUsers {get; set;}

        public DbSet<Associates> AssociatesGuest {get; set;}

        public DbSet<FormEvent> EventForms {get; set;}
    }
}