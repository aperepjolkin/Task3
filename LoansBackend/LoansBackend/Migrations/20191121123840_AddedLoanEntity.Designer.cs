﻿// <auto-generated />
using System;
using LoansBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoansBackend.Migrations
{
    [DbContext(typeof(LoansContext))]
    [Migration("20191121123840_AddedLoanEntity")]
    partial class AddedLoanEntity
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

                    b.Property<int?>("LoanId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LoanId");

                    b.ToTable("Borrowers");
                });

            modelBuilder.Entity("LoansBackend.Models.Lender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance");

                    b.Property<int?>("LoanId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LoanId");

                    b.ToTable("Lenders");
                });

            modelBuilder.Entity("LoansBackend.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<decimal>("LoanBalance");

                    b.HasKey("LoanId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("LoansBackend.Models.Borrower", b =>
                {
                    b.HasOne("LoansBackend.Models.Loan")
                        .WithMany("Borrowers")
                        .HasForeignKey("LoanId");
                });

            modelBuilder.Entity("LoansBackend.Models.Lender", b =>
                {
                    b.HasOne("LoansBackend.Models.Loan")
                        .WithMany("Lenders")
                        .HasForeignKey("LoanId");
                });
#pragma warning restore 612, 618
        }
    }
}
