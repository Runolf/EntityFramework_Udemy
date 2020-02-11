using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public class LisamContext: DbContext
    {
        public DbSet<Client> Clients{ get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Users> Users { get; set; }

        public LisamContext():base("name=DefaultConnection")  // -> DefaultConnection = name of the connectionstring in App.Config
        {

        }

        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(t => t.Name)
                .IsRequired();

        }
        */ 
    }
}
