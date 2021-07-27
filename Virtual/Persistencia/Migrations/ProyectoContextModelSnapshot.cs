﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Virtual;

namespace Persistencia.Migrations
{
    [DbContext(typeof(ProyectoContext))]
    partial class ProyectoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.clases.Configuracion", b =>
                {
                    b.Property<int>("ConfiguracionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MinHorasExtra")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("Modelo.clases.Deducciones", b =>
                {
                    b.Property<int>("DeduccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Anticipos")
                        .HasColumnType("real");

                    b.Property<float>("AportePersonal")
                        .HasColumnType("real");

                    b.Property<float>("Comisariato")
                        .HasColumnType("real");

                    b.Property<float>("DeduccionesTotal")
                        .HasColumnType("real");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<float>("Multas")
                        .HasColumnType("real");

                    b.HasKey("DeduccionId");

                    b.HasIndex("EmpleadoId")
                        .IsUnique();

                    b.ToTable("deducciones");
                });

            modelBuilder.Entity("Modelo.clases.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("Modelo.clases.Ingresos", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Comisiones")
                        .HasColumnType("real");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("HorasExtras")
                        .HasColumnType("int");

                    b.Property<float>("IngresosTotal")
                        .HasColumnType("real");

                    b.Property<float>("Sueldo")
                        .HasColumnType("real");

                    b.HasKey("IngresoId");

                    b.HasIndex("EmpleadoId")
                        .IsUnique();

                    b.ToTable("ingresos");
                });

            modelBuilder.Entity("Modelo.clases.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.ToTable("sucursales");
                });

            modelBuilder.Entity("Modelo.clases.Sueldo", b =>
                {
                    b.Property<int>("TotalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<float>("SueldoTotal")
                        .HasColumnType("real");

                    b.HasKey("TotalId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("totales");
                });

            modelBuilder.Entity("Modelo.clases.Deducciones", b =>
                {
                    b.HasOne("Modelo.clases.Empleado", "Empleado")
                        .WithOne("Deducciones")
                        .HasForeignKey("Modelo.clases.Deducciones", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo.clases.Empleado", b =>
                {
                    b.HasOne("Modelo.clases.Sucursal", "Sucursal")
                        .WithMany("Empleados")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Modelo.clases.Ingresos", b =>
                {
                    b.HasOne("Modelo.clases.Empleado", "Empleado")
                        .WithOne("Ingresos")
                        .HasForeignKey("Modelo.clases.Ingresos", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo.clases.Sueldo", b =>
                {
                    b.HasOne("Modelo.clases.Empleado", "Empleado")
                        .WithMany("Sueldos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo.clases.Empleado", b =>
                {
                    b.Navigation("Deducciones");

                    b.Navigation("Ingresos");

                    b.Navigation("Sueldos");
                });

            modelBuilder.Entity("Modelo.clases.Sucursal", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
