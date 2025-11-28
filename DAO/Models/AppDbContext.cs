using System;
using System.Collections.Generic;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Locker> Lockers { get; set; }

    public virtual DbSet<Repartidore> Repartidores { get; set; }

    public virtual DbSet<Residente> Residentes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DBConfigurations.getDbConectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Locker>(entity =>
        {
            entity.HasKey(e => e.LockerId).HasName("PK__lockers__5747040B188EF5DF");

            entity.ToTable("lockers");

            entity.Property(e => e.LockerId)
                .ValueGeneratedNever()
                .HasColumnName("lockerId");
            entity.Property(e => e.CodigoActual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_actual");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaDeposito)
                .HasColumnType("datetime")
                .HasColumnName("fecha_deposito");
            entity.Property(e => e.RepartidorId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("repartidorId");
            entity.Property(e => e.ResidenteId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("residenteId");
            entity.Property(e => e.Tamano)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tamano");
            entity.Property(e => e.TrackingPaquete)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tracking_paquete");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UltimaMantencion)
                .HasColumnType("datetime")
                .HasColumnName("ultima_mantencion");

            entity.HasOne(d => d.idRepartidorNavigation).WithMany(p => p.Lockers)
                .HasForeignKey(d => d.RepartidorId)
                 .IsRequired(false) 
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.idResidenteNavigation).WithMany(p => p.Lockers)
                .HasForeignKey(d => d.ResidenteId)
                .IsRequired(false)  
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Repartidore>(entity =>
        {
            entity.HasKey(e => e.RepartidorId).HasName("PK__repartid__4D1DF5E39FA75136");

            entity.ToTable("repartidores");

            entity.Property(e => e.RepartidorId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("repartidorId");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CredencialValida).HasColumnName("credencial_valida");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.LegajoNumero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("legajo_numero");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Residente>(entity =>
        {
            entity.HasKey(e => e.ResidenteId).HasName("PK__resident__A733F702AD6F4991");

            entity.ToTable("residentes");

            entity.Property(e => e.ResidenteId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("residenteId");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Departamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PrefNotif)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pref_notif");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__usuario__2ED7D2AF8A465510");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.NombreUsuario, "UQ__usuario__81B20F41C545C9B1").IsUnique();

            entity.Property(e => e.UsuarioId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("usuario_id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_Usuario");
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rol");

      
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
