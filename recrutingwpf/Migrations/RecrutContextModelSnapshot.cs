﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using recrutingwpf.Models;

namespace recrutingwpf.Migrations
{
    [DbContext(typeof(RecrutContext))]
    partial class RecrutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("recrutingwpf.Models.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Education")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Patronomic")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("recrutingwpf.Models.Hirer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hirers");
                });

            modelBuilder.Entity("recrutingwpf.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AppId")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("recrutingwpf.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("HirerId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PaymentCost")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("HirerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("recrutingwpf.Models.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AppIdId")
                        .HasColumnType("integer");

                    b.Property<int>("IdApp")
                        .HasColumnType("integer");

                    b.Property<int>("IdOrder")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderIdId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppIdId");

                    b.HasIndex("OrderIdId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("recrutingwpf.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("recrutingwpf.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImageAvatar")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("recrutingwpf.Models.Applicant", b =>
                {
                    b.HasOne("recrutingwpf.Models.User", "User")
                        .WithOne("Applicant")
                        .HasForeignKey("recrutingwpf.Models.Applicant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("recrutingwpf.Models.Hirer", b =>
                {
                    b.HasOne("recrutingwpf.Models.User", "User")
                        .WithOne("Hirer")
                        .HasForeignKey("recrutingwpf.Models.Hirer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("recrutingwpf.Models.Image", b =>
                {
                    b.HasOne("recrutingwpf.Models.Applicant", "App")
                        .WithMany("ImageId")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("recrutingwpf.Models.Order", b =>
                {
                    b.HasOne("recrutingwpf.Models.Applicant", null)
                        .WithMany("OrderId")
                        .HasForeignKey("ApplicantId");

                    b.HasOne("recrutingwpf.Models.Hirer", "Hirer")
                        .WithMany()
                        .HasForeignKey("HirerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("recrutingwpf.Models.Response", b =>
                {
                    b.HasOne("recrutingwpf.Models.Applicant", "AppId")
                        .WithMany("RespId")
                        .HasForeignKey("AppIdId");

                    b.HasOne("recrutingwpf.Models.Order", "OrderId")
                        .WithMany("Responses")
                        .HasForeignKey("OrderIdId");
                });

            modelBuilder.Entity("recrutingwpf.Models.User", b =>
                {
                    b.HasOne("recrutingwpf.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
