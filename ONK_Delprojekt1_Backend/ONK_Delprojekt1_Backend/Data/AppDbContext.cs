using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ONK_Delprojekt1_Backend.Models;
using System.Configuration;
using System.Data.SqlClient;

//using RestApi;

namespace ONK_Delprojekt1_Backend.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions options)
                :base(options)
            {
            }

            public DbSet<Haandvaerker> Haandvaerkerer { get; set; }
            public DbSet<Vaerktoej> Vaerktoejer { get; set; }
            public DbSet<Vaerktoejskasse> Vaerktoejskasser{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["DitStamtrae"].ConnectionString;
            optionsBuilder.UseSqlServer("data source=localhost;Database=testONK.db; " +
                "initial catalog=testOnk.dk; persist security info = True;Integrated Security = SSPI");
           
            //;Uid=root;Pwd=root;
            //optionsBuilder.UseMySql("Server=localhost;Database=testONK.db;Uid=root;Pwd=root;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Vaerktoej>()
                    .HasOne(vk => vk.LiggerIvtkNavigation)
                    .WithMany(v => v.Vaerktoej);

                modelBuilder.Entity<Vaerktoejskasse>()
                    .HasOne(h => h.EjesAfNavigation)
                    .WithMany(vk => vk.Vaerktoejskasse);
            }

        }
}
