﻿// <auto-generated />
using System;
using ExelTechApi.Service.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExelTechAPI.ExelTechApi.Service.Model.Migrations
{
    [DbContext(typeof(ExelTechDbContext))]
    [Migration("20240208055856_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExelTechApi.Service.Model.Allergy", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AId"), 1L, 1);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("AId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.NCD", b =>
                {
                    b.Property<int>("NId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NId");

                    b.ToTable("NCDs");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.Patient", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<bool?>("Epilepcy")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
