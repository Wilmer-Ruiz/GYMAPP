using Entidades;
using Repositorio;

namespace GYMAPP.Service
{
    public class listaServicio : IlistaServicio
    {

        private readonly IListasRepositorio _listasRepositorio;

        public listaServicio(IListasRepositorio listasRepositorio)
        {
            _listasRepositorio = listasRepositorio;
        }

        public async Task<IEnumerable<Cita>> GetCitasDisponibles(DateTime fecha)
        {
            var todasLasCitas = await _listasRepositorio.GetAllCitas();
            var citasDelDia = todasLasCitas.Where(c => c.FechaHora.Date == fecha.Date);

            // Lógica para determinar horarios disponibles
            return citasDelDia;
        }

        public async Task<bool> AgendarCita(Cita cita)
        {
            try
            {
                await _listasRepositorio.AddCita(cita);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CancelarCita(int citaId)
        {
            try
            {
                await _listasRepositorio.DeleteCita(citaId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Cita>> GetCitasCliente(int clienteId)
        {
            return await _listasRepositorio.GetCitasByCliente(clienteId);
        }
    }
}
