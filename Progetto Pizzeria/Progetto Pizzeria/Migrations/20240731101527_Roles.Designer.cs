﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Progetto_Pizzeria.Context;

#nullable disable

namespace Progetto_Pizzeria.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240731101527_Roles")]
    partial class Roles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IngredienteProdotto", b =>
                {
                    b.Property<int>("IngredientiId")
                        .HasColumnType("int");

                    b.Property<int>("ProdottiId")
                        .HasColumnType("int");

                    b.HasKey("IngredientiId", "ProdottiId");

                    b.HasIndex("ProdottiId");

                    b.ToTable("IngredienteProdotto");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Ingredienti");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Ordine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Evaso")
                        .HasColumnType("bit");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Noteaggiuntive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ordini");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Prodotto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Immagine")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Prezzo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TempoDiConsegna")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prodotti");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.ProdottoOrdinato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrdineId")
                        .HasColumnType("int");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdineId");

                    b.ToTable("Prodottiordinati");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Roles__3214EC0797369540");

                    b.HasIndex(new[] { "Name" }, "UQ__Roles__737584F6C7B8672F")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id")
                        .HasName("PK__Users__3214EC0798BFEE9C");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534BF460FE6")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__UserRol__3214EC07D639C897");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "UserId", "RoleId" }, "UK_UsersRoles")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("IngredienteProdotto", b =>
                {
                    b.HasOne("Progetto_Pizzeria.Models.Ingrediente", null)
                        .WithMany()
                        .HasForeignKey("IngredientiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Progetto_Pizzeria.Models.Prodotto", null)
                        .WithMany()
                        .HasForeignKey("ProdottiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Ordine", b =>
                {
                    b.HasOne("Progetto_Pizzeria.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.ProdottoOrdinato", b =>
                {
                    b.HasOne("Progetto_Pizzeria.Models.Ordine", null)
                        .WithMany("ProdottiOrdinati")
                        .HasForeignKey("OrdineId");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.UserRole", b =>
                {
                    b.HasOne("Progetto_Pizzeria.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_UserRoles_Roles");

                    b.HasOne("Progetto_Pizzeria.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_UserRoles_Users");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Ordine", b =>
                {
                    b.Navigation("ProdottiOrdinati");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Progetto_Pizzeria.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
