using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

#nullable disable

namespace DAL.Data
{
    public partial class BookingContext : DbContext
    {
        public BookingContext()
        {
        }

        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Backup> Backups { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<Dvv> Dvvs { get; set; }
        public virtual DbSet<Familia> Familias { get; set; }
        public virtual DbSet<FamiliaUsuario> FamiliaUsuarios { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }
        public virtual DbSet<OrdenProducto> OrdenProductos { get; set; }
        public virtual DbSet<Patente> Patentes { get; set; }
        public virtual DbSet<PatenteFamilium> PatenteFamilia { get; set; }
        public virtual DbSet<PatenteUsuario> PatenteUsuarios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<ReservaProducto> ReservaProductos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: false)
                        .Build();
                    optionsBuilder.UseSqlServer(configuration.GetConnectionString("SQLConnection"));
                }
            }
            catch (Exception)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    string conn = string.Empty;
                    int counter = 0;
                    foreach (string line in File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "ConnectionStrings.txt"))
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            conn = Encriptacion.Encriptacion.DecryptString(line);
                        }
                        counter++;
                    }

                    optionsBuilder.UseSqlServer(conn);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.HasKey(e => e.IdBackup);

                entity.ToTable("Backup");

                entity.Property(e => e.IdBackup).ValueGeneratedOnAdd();

                entity.Property(e => e.Directorio).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Backups)
                    .HasForeignKey(d => d.IdUsuario)                    
                    .HasConstraintName("FK_Backup_Usuarios");
                    
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.IdBicatora);

                entity.ToTable("Bitacora");

                entity.Property(e => e.IdBicatora).ValueGeneratedNever();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Bitacora_Usuarios");
            });

            modelBuilder.Entity<Dvv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DVV");

                entity.Property(e => e.Dvv1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvv");

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Familia>(entity =>
            {
                entity.HasKey(e => e.IdFamilia)
                    .HasName("PK_Familia");

                entity.Property(e => e.IdFamilia).ValueGeneratedNever();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");
            });

            modelBuilder.Entity<FamiliaUsuario>(entity =>
            {
                entity.HasKey(e => e.IdFamiliaUsuario);

                entity.ToTable("FamiliaUsuario");

                entity.Property(e => e.IdFamiliaUsuario).ValueGeneratedNever();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.HasOne(d => d.IdFamiliaNavigation)
                    .WithMany(p => p.FamiliaUsuarios)
                    .HasForeignKey(d => d.IdFamilia)
                    .HasConstraintName("FK_FamiliaUsuario_Familias");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FamiliaUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_FamiliaUsuario_Usuarios");
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.Property(e => e.IdOrden).ValueGeneratedNever();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.OrdenCompras)
                    .HasForeignKey(d => d.IdSala)
                    .HasConstraintName("FK_OrdenCompras_Salas");
            });

            modelBuilder.Entity<OrdenProducto>(entity =>
            {
                entity.HasKey(e => e.IdOrdenProducto)
                    .HasName("PK_IdOrdenProducto");

                entity.ToTable("OrdenProducto");

                entity.Property(e => e.IdOrdenProducto).ValueGeneratedNever();

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.OrdenProductos)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("FK_OrdenProducto_OrdenCompras");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.OrdenProductos)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_OrdenProducto_Productos");
            });

            modelBuilder.Entity<Patente>(entity =>
            {
                entity.HasKey(e => e.IdPatente)
                    .HasName("PK_Patente");

                entity.Property(e => e.IdPatente).ValueGeneratedOnAdd();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");
            });

            modelBuilder.Entity<PatenteFamilium>(entity =>
            {
                entity.HasKey(e => e.IdPatenteFamilia);

                entity.Property(e => e.IdPatenteFamilia).ValueGeneratedNever();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.HasOne(d => d.IdFamiliaNavigation)
                    .WithMany(p => p.PatenteFamilia)
                    .HasForeignKey(d => d.IdFamilia)
                    .HasConstraintName("FK_PatenteFamilia_Familias");

                entity.HasOne(d => d.IdPatenteNavigation)
                    .WithMany(p => p.PatenteFamilia)
                    .HasForeignKey(d => d.IdPatente)
                    .HasConstraintName("FK_PatenteFamilia_Patentes");
            });

            modelBuilder.Entity<PatenteUsuario>(entity =>
            {
                entity.HasKey(e => e.IdPatenteUsuario);

                entity.ToTable("PatenteUsuario");

                entity.Property(e => e.IdPatenteUsuario).ValueGeneratedOnAdd();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.HasOne(d => d.IdPatenteNavigation)
                    .WithMany(p => p.PatenteUsuarios)
                    .HasForeignKey(d => d.IdPatente)
                    .HasConstraintName("FK_PatenteUsuario_Patentes");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.PatenteUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_PatenteUsuario_Usuarios");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.Property(e => e.IdProducto).ValueGeneratedNever();

                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);

                entity.Property(e => e.IdReserva).ValueGeneratedNever();

                entity.Property(e => e.Dvh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("FK_Reservas_OrdenCompras");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdSala)
                    .HasConstraintName("FK_Reservas_Salas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_Reserva_Usuarios");
            });

            modelBuilder.Entity<ReservaProducto>(entity =>
            {
                entity.HasKey(e => e.IdReservaProducto);

                entity.ToTable("ReservaProducto");

                entity.Property(e => e.IdReservaProducto).ValueGeneratedNever();

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ReservaProductos)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_ReservaProducto_Productos");

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.ReservaProductos)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK_ReservaProducto_Reservas");
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.IdSala);

                entity.Property(e => e.IdSala).ValueGeneratedNever();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContraseA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Contrase�a");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Dvh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dvh");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
