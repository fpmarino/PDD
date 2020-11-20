﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BlazorApp1.Data.Detalles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTarea")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecurId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("RecurId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("BlazorApp1.Data.Recursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("BlazorApp1.Data.Tareas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estimacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdRecursos")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResponsableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ResponsableId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("BlazorApp1.Data.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BlazorApp1.Data.Detalles", b =>
                {
                    b.HasOne("BlazorApp1.Data.Recursos", "Recur")
                        .WithMany()
                        .HasForeignKey("RecurId");

                    b.HasOne("BlazorApp1.Data.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId");

                    b.Navigation("Recur");

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("BlazorApp1.Data.Recursos", b =>
                {
                    b.HasOne("BlazorApp1.Data.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BlazorApp1.Data.Tareas", b =>
                {
                    b.HasOne("BlazorApp1.Data.Recursos", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableId");

                    b.Navigation("Responsable");
                });
#pragma warning restore 612, 618
        }
    }
}
