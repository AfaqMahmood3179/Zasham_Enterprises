﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zasham_Enterprises.Model;

#nullable disable

namespace Zasham_Enterprises.Migrations
{
    [DbContext(typeof(CustomerDB_Context))]
    [Migration("20230509064532_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Zasham_Enterprises.Model.Customer", b =>
                {
                    b.Property<string>("Customer_phone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Customer_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_phone");

                    b.ToTable("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
