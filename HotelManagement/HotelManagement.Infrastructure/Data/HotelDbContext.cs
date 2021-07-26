using System;
using System.Collections.Generic;
using HotelManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HotelManagement.Infrastructure.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms{ get; set; }
        public DbSet <Roomtype> Roomtypes { get; set; }
        public DbSet <Service> Services{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(ConfigureCustomer);
            modelBuilder.Entity<Room>(ConfigureRoom);
            modelBuilder.Entity<Roomtype>(ConfigureRoomtype);
            modelBuilder.Entity<Service>(ConfigureService);
        }

        private void ConfigureService(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(s=>s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.HasOne(s => s.Rooms).WithMany(r => r.Services).HasForeignKey(r => r.RoomNo);
            builder.Property(s => s.SDesc).HasMaxLength(50);
            builder.Property(s => s.Amount).HasColumnType("decimal(5, 2)");
            builder.Property(s => s.ServiceDate).HasColumnType("datetime2");
        }

        private void ConfigureRoomtype(EntityTypeBuilder<Roomtype> builder)
        {
            builder.ToTable("Roomtypes");
            builder.HasKey(rt => rt.Id);
            builder.Property(rt => rt.Id).ValueGeneratedOnAdd();
            builder.Property(rt => rt.RTDesc).HasMaxLength(20);
            builder.Property(rt => rt.Rent).HasColumnType("decimal(5, 2)");
        }

        private void ConfigureRoom(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.HasOne(r => r.Roomtype).WithMany(r => r.Rooms).HasForeignKey(r => r.RTCode);

        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.HasOne(c => c.Room).WithMany(c => c.Customers).HasForeignKey(c => c.RoomNo);
            builder.Property(c => c.CName).HasMaxLength(20);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.Phone).HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(40);
            builder.Property(c => c.Checkin).HasColumnType("datetime2");
            builder.Property(c => c.Advance).HasColumnType("decimal(5, 2)");
        }
    }
}
