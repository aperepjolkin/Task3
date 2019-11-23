﻿// <auto-generated />
using LoansBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoansBackend.Migrations
{
    [DbContext(typeof(LoansContext))]
    [Migration("20191121122934_AddedBalace")]
    partial class AddedBalace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoansBackend.Models.Borrower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Borrowers");
                });

            modelBuilder.Entity("LoansBackend.Models.Lender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Lenders");
                });
#pragma warning restore 612, 618
        }
    }
}
