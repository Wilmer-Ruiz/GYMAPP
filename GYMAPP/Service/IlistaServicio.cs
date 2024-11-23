using Entidades;

namespace GYMAPP.Service
{
    public interface IlistaServicio
    {

        Task<IEnumerable<Cita>> GetCitasDisponibles(DateTime fecha);
        Task<bool> AgendarCita(Cita cita);
        Task<bool> CancelarCita(int citaId);
        Task<IEnumerable<Cita>> GetCitasCliente(int clienteId);

        
    }
}
