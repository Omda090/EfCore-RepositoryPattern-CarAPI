﻿// <auto-generated />
using Cars_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCore_RepositoryPattern_CarAPI.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20211006111746_tert")]
    partial class tert
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cars_API.Models.Dto.TodoDto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Model")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("TodoDtos");
                });
#pragma warning restore 612, 618
        }
    }
}
