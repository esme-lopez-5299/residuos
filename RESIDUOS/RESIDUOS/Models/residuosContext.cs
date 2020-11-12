using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RESIDUOS.Models
{
    public partial class residuosContext : DbContext
    {
        public residuosContext()
        {
        }

        public residuosContext(DbContextOptions<residuosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Escuela> Escuelas { get; set; }
        public virtual DbSet<Localidad> Localidads { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=residuos", x => x.ServerVersion("5.7.18-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PRIMARY");

                entity.ToTable("curso");

                entity.Property(e => e.IdCurso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCurso");

                entity.Property(e => e.UrlVideo1)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("urlVideo1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlVideo2)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("urlVideo2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlVideo3)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("urlVideo3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlVideo4)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("urlVideo4")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasKey(e => e.IdEscuela)
                    .HasName("PRIMARY");

                entity.ToTable("escuela");

                entity.HasIndex(e => e.IdLocalidad, "fk_localidad");

                entity.Property(e => e.IdEscuela)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEscuela");

                entity.Property(e => e.Clave)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnType("int(11)")
                    .HasColumnName("idLocalidad");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumeroAlumnos).HasColumnType("int(11)");

                entity.Property(e => e.NumeroMaestros).HasColumnType("tinyint(4)");

                entity.Property(e => e.Turno)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Escuelas)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_localidad");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PRIMARY");

                entity.ToTable("localidad");

                entity.HasIndex(e => e.IdMunicipio, "fk_municipio");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnType("int(11)")
                    .HasColumnName("idLocalidad");

                entity.Property(e => e.IdMunicipio)
                    .HasColumnType("int(11)")
                    .HasColumnName("idMunicipio");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumeroEscuelas)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("numeroEscuelas");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Localidads)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_municipio");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio)
                    .HasName("PRIMARY");

                entity.ToTable("municipio");

                entity.Property(e => e.IdMunicipio).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumEscuelas).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.IdEscuela, "fk_escuela");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("idUsuario");

                entity.Property(e => e.ApellidoM)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoP)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("contraseña")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEscuela)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEscuela");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("Usuario")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEscuelaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEscuela)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_escuela");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
