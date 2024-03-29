﻿// <auto-generated />
using System;
using ExelTechApi.Service.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExelTechApi.Service.Model.Migrations
{
    [DbContext(typeof(ExelTechDbContext))]
    [Migration("20240211051003_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExelTechApi.Service.Model.Allergies_Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Allergy_Id")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Allergies_Details");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.Allergy", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.DiseaseInformation", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DId");

                    b.ToTable("DiseaseInformation");
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

            modelBuilder.Entity("ExelTechApi.Service.Model.NCD_Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NCDId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("NCD_Details");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.Patient", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<int?>("DId")
                        .HasColumnType("int");

                    b.Property<bool?>("Epilepcy")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.Allergies_Details", b =>
                {
                    b.HasOne("ExelTechApi.Service.Model.Patient", "Patient")
                        .WithMany("AllergiesDetails")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.NCD_Details", b =>
                {
                    b.HasOne("ExelTechApi.Service.Model.Patient", "Patient")
                        .WithMany("NCDDetails")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ExelTechApi.Service.Model.Patient", b =>
                {
                    b.Navigation("AllergiesDetails");

                    b.Navigation("NCDDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
