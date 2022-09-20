﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeluqueriaStar.App.Persistencia;

namespace PeluqueriaStar.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.CitaAsignada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MembresiaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembresiaId");

                    b.ToTable("CitaAsignada");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.HorarioEstelista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HorarioEstelista");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Membresia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ActivadaMembresia")
                        .HasColumnType("bit");

                    b.Property<int>("ValorDescuento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Membresia");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstadoSalud")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.ServiciosOfrecer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValorServicio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiciosOfrecer");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("PeluqueriaStar.App.Dominio.Persona");

                    b.Property<int?>("CitaAsignadaId")
                        .HasColumnType("int")
                        .HasColumnName("Administrador_CitaAsignadaId");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("EstelistaId")
                        .HasColumnType("int")
                        .HasColumnName("Administrador_EstelistaId");

                    b.Property<int?>("HorarioEstelistaId")
                        .HasColumnType("int")
                        .HasColumnName("Administrador_HorarioEstelistaId");

                    b.Property<int?>("MembresiaId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiciosOfrecerId")
                        .HasColumnType("int")
                        .HasColumnName("Administrador_ServiciosOfrecerId");

                    b.HasIndex("CitaAsignadaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstelistaId");

                    b.HasIndex("HorarioEstelistaId");

                    b.HasIndex("MembresiaId");

                    b.HasIndex("ServiciosOfrecerId");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("PeluqueriaStar.App.Dominio.Persona");

                    b.Property<int?>("CitaAsignadaId")
                        .HasColumnType("int");

                    b.Property<string>("Dirrecion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int?>("EstelistaId")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.HasIndex("CitaAsignadaId");

                    b.HasIndex("EstelistaId");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Estelista", b =>
                {
                    b.HasBaseType("PeluqueriaStar.App.Dominio.Persona");

                    b.Property<int?>("HorarioEstelistaId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiciosOfrecerId")
                        .HasColumnType("int");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("HorarioEstelistaId");

                    b.HasIndex("ServiciosOfrecerId");

                    b.HasDiscriminator().HasValue("Estelista");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.CitaAsignada", b =>
                {
                    b.HasOne("PeluqueriaStar.App.Dominio.Membresia", "Membresia")
                        .WithMany()
                        .HasForeignKey("MembresiaId");

                    b.Navigation("Membresia");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Administrador", b =>
                {
                    b.HasOne("PeluqueriaStar.App.Dominio.CitaAsignada", "CitaAsignada")
                        .WithMany()
                        .HasForeignKey("CitaAsignadaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("PeluqueriaStar.App.Dominio.Estelista", "Estelista")
                        .WithMany()
                        .HasForeignKey("EstelistaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.HorarioEstelista", "HorarioEstelista")
                        .WithMany()
                        .HasForeignKey("HorarioEstelistaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.Membresia", "Membresia")
                        .WithMany()
                        .HasForeignKey("MembresiaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.ServiciosOfrecer", "ServiciosOfrecer")
                        .WithMany()
                        .HasForeignKey("ServiciosOfrecerId");

                    b.Navigation("CitaAsignada");

                    b.Navigation("Cliente");

                    b.Navigation("Estelista");

                    b.Navigation("HorarioEstelista");

                    b.Navigation("Membresia");

                    b.Navigation("ServiciosOfrecer");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Cliente", b =>
                {
                    b.HasOne("PeluqueriaStar.App.Dominio.CitaAsignada", "CitaAsignada")
                        .WithMany()
                        .HasForeignKey("CitaAsignadaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.Estelista", "Estelista")
                        .WithMany()
                        .HasForeignKey("EstelistaId");

                    b.Navigation("CitaAsignada");

                    b.Navigation("Estelista");
                });

            modelBuilder.Entity("PeluqueriaStar.App.Dominio.Estelista", b =>
                {
                    b.HasOne("PeluqueriaStar.App.Dominio.HorarioEstelista", "HorarioEstelista")
                        .WithMany()
                        .HasForeignKey("HorarioEstelistaId");

                    b.HasOne("PeluqueriaStar.App.Dominio.ServiciosOfrecer", "ServiciosOfrecer")
                        .WithMany()
                        .HasForeignKey("ServiciosOfrecerId");

                    b.Navigation("HorarioEstelista");

                    b.Navigation("ServiciosOfrecer");
                });
#pragma warning restore 612, 618
        }
    }
}
