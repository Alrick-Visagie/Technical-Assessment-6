﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleWebService.Models;

namespace VehicleWebService.Migrations
{
    [DbContext(typeof(VehicleDetailsDBContext))]
    partial class VehicleDetailsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleWebService.Models.VehicleDetails", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("VehicleMake")
                        .IsRequired();

                    b.Property<string>("VehicleModel")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("VehicleId");

                    b.ToTable("VehicleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
