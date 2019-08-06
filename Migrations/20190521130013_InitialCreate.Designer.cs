﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectEuler.Models;

namespace ProjectEuler.Migrations
{
    [DbContext(typeof(CodeSolutionContext))]
    [Migration("20190521130013_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("ProjectEuler.Models.CodeSolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Problem");

                    b.Property<string>("ProjectEulerLink");

                    b.Property<string>("Solution");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("CodeSolution");
                });
#pragma warning restore 612, 618
        }
    }
}
