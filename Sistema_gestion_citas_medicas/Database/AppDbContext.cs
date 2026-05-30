using Microsoft.EntityFrameworkCore;
using Sistema_gestion_citas_medicas.Models;

public class AppDbContext : DbContext
{
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Recordatorio> Recordatorios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer
            (
         @"Server=localhost\SQLEXPRESS;Database=SistemaCitas;Trusted_Connection=True;TrustServerCertificate=True"
            );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<People>()
            .ToTable("Personas")
            .HasDiscriminator<string>("Tipo")
            .HasValue<Paciente>("Paciente")
            .HasValue<Medico>("Medico");

        modelBuilder.Entity<People>();

        modelBuilder.Entity<Cita>()
            .Property(c => c.Estado)
            .HasConversion<string>();

        modelBuilder.Entity<Recordatorio>()
            .Property(r => r.Tipo)
            .HasConversion<string>();

        modelBuilder.Entity<Recordatorio>()
            .Property(r => r.Estado)
            .HasConversion<string>();

        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Paciente)
            .WithMany()
            .HasForeignKey(c => c.PacienteId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Cita>()
            .HasOne(c => c.Medico)
            .WithMany()
            .HasForeignKey(c => c.MedicoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
