﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_Scripture_Journal.Models;

namespace My_Scripture_Journal.Migrations
{
    [DbContext(typeof(My_Scripture_JournalContext))]
    [Migration("20190225184413_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("My_Scripture_Journal.Models.Entry", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Book");

                b.Property<int>("Chapter");

                b.Property<string>("DatePosted");

                b.Property<string>("Note");

                b.Property<string>("StandardWork");

                b.Property<string>("Verses");

                b.HasKey("ID");

                b.ToTable("Entry");
            });
#pragma warning restore 612, 618
        }
    }
}
