using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Repositorios
{
    public class PacienteRepository : ICrud<Paciente>
    {
        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
            => _context = context;

        public List<Paciente> ObtenerTodos()
            => _context.Pacientes.ToList();

        public Paciente ObtenerPorId(int id)
            => _context.Pacientes.Find(id);

        public void Agregar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public void Actualizar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }
        }
    }
}
