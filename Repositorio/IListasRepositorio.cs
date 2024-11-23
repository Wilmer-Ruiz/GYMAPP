using Entidades;

namespace Repositorio
{
    public interface IListasRepositorio
    {
        Task<IEnumerable<Cliente>> GetAllClientes();
        Task<IEnumerable<Cliente?>> GetClienteById(int id);
        Task<Cliente> AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(int id);

        Task<IEnumerable<Trabajador>> GetAllTrabajadores();
        Task<Trabajador?> GetTrabajadorById(int id);
        Task<Trabajador> AddTrabajador(Trabajador trabajador);
        Task UpdateTrabajador(Trabajador trabajador);
        Task DeleteTrabajador(int id);

        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita?> GetCitaById(int id);
        Task<IEnumerable<Cita>> GetCitasByCliente(int clienteId);
        Task<IEnumerable<Cita>> GetCitasByTrabajador(int trabajadorId);
        Task<IEnumerable<Cita>> AddCita(Cita cita);
        Task UpdateCita(Cita cita);
        Task DeleteCita(int id);
    }
}
