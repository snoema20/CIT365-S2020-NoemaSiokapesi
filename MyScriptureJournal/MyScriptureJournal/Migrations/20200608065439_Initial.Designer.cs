﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_Scripture_Journal.Models;
using MyScriptureJournal.Models;

namespace My_Scripture_Journal.Migrations
{
    [DbContext(typeof(My_Scripture_JournalContext))]
    [Migration("20191102181812_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("My_Scripture_Journal.Models.Scripture", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Book")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Chapter")
                    .HasColumnType("decimal(18,2)");

                b.Property<DateTime>("DateAdded")
                    .HasColumnType("datetime2");

                b.Property<string>("Note")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("NoteTitle")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Passage")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Verse")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("ID");

                b.ToTable("Scripture");
            });
#pragma warning restore 612, 618
        }
    }
}
