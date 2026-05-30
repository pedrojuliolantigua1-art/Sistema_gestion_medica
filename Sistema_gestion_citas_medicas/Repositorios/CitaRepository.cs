using Sistema_gestion_citas_medicas.Models;
using Sistema_gestion_citas_medicas.Interfaces;
using Microsoft.EntityFrameworkCore;
using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Repositorios
{
    public class CitaRepository : ICitaRepository
    {
        private readonly AppDbContext _context;

        public CitaRepository(AppDbContext context)
            => _context = context;

        public List<Cita> ObtenerTodos()
            => _context.Citas
                .Include(c => c.Paciente)
                .Include(c => c.Medico)
                .ToList();

        public Cita ObtenerPorId(int id)
            => _context.Citas
                .Include(c => c.Paciente)
                .Include(c => c.Medico)
                .FirstOrDefault(c => c.Id == id);

        public List<Cita> ObtenerPorPaciente(int pacienteId)
            => _context.Citas
                .Include(c => c.Medico)
                .Where(c => c.PacienteId == pacienteId)
                .ToList();

        public List<Cita> ObtenerPorMedico(int medicoId)
            => _context.Citas
                .Include(c => c.Paciente)
                .Where(c => c.MedicoId == medicoId)
                .ToList();

        public void Agregar(Cita cita)
        {
            _context.Citas.Add(cita);
            _context.SaveChanges();
        }

        public void Actualizar(Cita cita)
        {
            _context.Citas.Update(cita);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var cita = _context.Citas.Find(id);
            if (cita != null)
            {
                _context.Citas.Remove(cita);
                _context.SaveChanges();
            }
        }
    }
}
