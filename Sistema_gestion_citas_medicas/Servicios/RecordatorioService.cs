using Sistema_gestion_citas_medicas.Interfaces;
using Sistema_gestion_citas_medicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_citas_medicas.Servicios
{
    public class RecordatorioService
    {
        private readonly IRecordatorio _repo;
        private readonly IEnviadorRecordatorio _enviador;

        public RecordatorioService(IRecordatorio repo, IEnviadorRecordatorio enviador)
        {
            _repo = repo;
            _enviador = enviador;
        }

        public void EnviarRecordatorio(int citaId)
        {
            var recordatorio = new Recordatorio
            {
                CitaId = citaId,
                Tipo = TipoRecordatorio.Email,
                Estado = EstadoRecordatorio.Pendiente
            };

            _repo.Agregar(recordatorio);

            try
            {
                _enviador.Enviar(citaId);

                _repo.ActualizarEstado(recordatorio.Id, EstadoRecordatorio.Enviado);
            }
            catch
            {
                _repo.ActualizarEstado(recordatorio.Id, EstadoRecordatorio.Fallido);
            }
        }

        public List<Recordatorio> ObtenerPorCita(int citaId)
            => _repo.ObtenerPorCita(citaId);
    }
}
