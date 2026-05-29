using Microsoft.EntityFrameworkCore;
using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;

namespace Sistema_gestion_citas_medicas.Repositorios
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AppDbContext _context;

        public MedicoRepository(AppDbContext context)
            => _context = context;

        public List<Medico> ObtenerTodos()
            => _context.Medicos.Include(m => m.Especialidad).ToList();

        public Medico ObtenerPorId(int id)
            => _context.Medicos.Include(m => m.Especialidad)
                               .FirstOrDefault(m => m.Id == id);

        public List<Medico> ObtenerPorEspecialidad(int especialidadId)
            => _context.Medicos.Include(m => m.Especialidad)
                               .Where(m => m.EspecialidadId == especialidadId)
                               .ToList();

        public void Agregar(Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
        }

        public void Actualizar(Medico medico)
        {
            _context.Medicos.Update(medico);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico != null)
            {
                _context.Medicos.Remove(medico);
                _context.SaveChanges();
            }
        }
    }
}
