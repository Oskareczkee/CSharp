﻿// <auto-generated />
using System;
using Language_Learning_App.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Language_Learning_App.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230706172550_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Language_Learning_App.DB.Models.Translation", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<string>("WordToTranslate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordTranslation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Language = 0,
                            WordToTranslate = "Hello",
                            WordTranslation = "Cześć"
                        },
                        new
                        {
                            ID = 2,
                            Language = 0,
                            WordToTranslate = "Car",
                            WordTranslation = "Samochód"
                        },
                        new
                        {
                            ID = 3,
                            Language = 0,
                            WordToTranslate = "Castle",
                            WordTranslation = "Zamek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}