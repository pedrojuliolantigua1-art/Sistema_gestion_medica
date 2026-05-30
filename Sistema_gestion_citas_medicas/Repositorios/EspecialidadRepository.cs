using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Repositorios
{
    public class EspecialidadRepository : IEspecialidadRepository
    {
        private readonly AppDbContext _context;

        public EspecialidadRepository(AppDbContext context)
            => _context = context;

        public List<Especialidad> ObtenerTodos()
            => _context.Especialidades.ToList();

        public Especialidad ObtenerPorId(int id)
            => _context.Especialidades.Find(id);

        public void Agregar(Especialidad especialidad)
        {
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();
        }

        public void Actualizar(Especialidad especialidad)
        {
            _context.Especialidades.Update(especialidad);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            if (especialidad != null)
            {
                _context.Especialidades.Remove(especialidad);
                _context.SaveChanges();
            }
        }
    }
}
