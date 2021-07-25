using System;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class FinalDbContext : DbContext
    {
        public FinalDbContext(DbContextOptions<FinalDbContext> options) : base(options)
        {
        }
        //==========DbSets==========//
        //DbSets as properties
        //Example:
        //public DbSet<Genre> Genres { get; set; }//This is the mapping

        //==========OnModelCreating==========//
        //private void ConfigureMovieCrew(EntityTypeBuilder<MovieCrew> builder){
        //  modelBuilder.Entity<Movie>(ConfigureMovie);
        //
        //}

        //============Configure============//
        //private void ConfigureCast(EntityTypeBuilder<Cast> builder)
        // builder.ToTable("Cast");
        //builder.HasKey(t => t.Id);
    }
}
