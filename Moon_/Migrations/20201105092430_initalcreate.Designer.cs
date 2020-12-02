﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moon.Models;

namespace Moon_.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20201105092430_initalcreate")]
    partial class initalcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moon.Entities.Files", b =>
                {
                    b.Property<string>("DocumentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("CourseCode");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<byte[]>("DataFiles");

                    b.Property<string>("FileType")
                        .HasMaxLength(100);

                    b.Property<string>("Lecturer");

                    b.Property<int>("Likes");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Title");

                    b.Property<string>("ownerId");

                    b.HasKey("DocumentId");

                    b.ToTable("Files");
                });

#pragma warning restore 612, 618
        }
    }
}