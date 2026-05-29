using Sistema_gestion_citas_medicas.Interfaces;
using SistemaCitas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_gestion_citas_medicas.Repositorios
{
    public class RecordatorioRepository : IRecordatorio
    {
        private readonly AppDbContext _context;
        public RecordatorioRepository(AppDbContext context)
            => _context = context;

        public void Agregar(Recordatorio recordatorio)
        {
            _context.Recordatorios.Add(recordatorio);
            _context.SaveChanges();
        }

        public List<Recordatorio> ObtenerPorCita(int citaId)
            => _context.Recordatorios
                .Where(r => r.CitaId == citaId)
                .ToList();

        public void ActualizarEstado(int id, EstadoRecordatorio estado)
        {
            var recordatorio = _context.Recordatorios.Find(id);
            if (recordatorio != null)
            {
                recordatorio.Estado = estado;
                recordatorio.EnviadoEn = DateTime.Now;
                _context.SaveChanges();
            }
        }
    }
}
