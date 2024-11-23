

using Dapper;
using Entidades;
using System.Data;
using System.Data.Common;

namespace Repositorio
{
    public class ListaRepositorio : IListasRepositorio
    {
        private readonly IDbConnection _dbconnection;

        public ListaRepositorio(IDbConnection dbconnection)
        {
            _dbconnection = dbconnection;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            var sql = @"select * from Clientes";
            return await _dbconnection.QueryAsync<Cliente>(sql, new {});
        }

        public async Task<IEnumerable<Cliente?>> GetClienteById(int id)
        {
            var sql = @"SELECT * FROM Clientes WHERE ClienteID = @Id";
            return await _dbconnection.QueryAsync<Cliente?>(sql, new { Id = id });
        }

        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            var sql = @"INSERT INTO Clientes (Nombre, Apellido, CorreoElectronico, Telefono) 
                    VALUES (@Nombre, @Apellido, @CorreoElectronico, @Telefono);
                    SELECT CAST(SCOPE_IDENTITY() as int)"
            ;

            cliente.ClienteID = await _dbconnection.QuerySingleAsync<int>(sql, cliente);
            return cliente;
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            var sql = @"UPDATE Clientes 
                    SET Nombre = @Nombre, 
                        Apellido = @Apellido, 
                        CorreoElectronico = @CorreoElectronico, 
                        Telefono = @Telefono 
                    WHERE ClienteID = @ClienteID"
            ;

            await _dbconnection.ExecuteAsync(sql, cliente);
        }

        public async Task DeleteCliente(int id)
        {
            await _dbconnection.ExecuteAsync(
                "DELETE FROM Clientes WHERE ClienteID = @Id", new { Id = id });
        }

        public async Task<IEnumerable<Trabajador>> GetAllTrabajadores()
        {
            var sql = @"select * from Trabajadores";
            return await _dbconnection.QueryAsync<Trabajador>(sql, new { });
        }

        public Task<Trabajador?> GetTrabajadorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Trabajador> AddTrabajador(Trabajador trabajador)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTrabajador(Trabajador trabajador)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTrabajador(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cita>> GetAllCitas()
        {
            throw new NotImplementedException();
        }

        public Task<Cita?> GetCitaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cita>> GetCitasByCliente(int clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cita>> GetCitasByTrabajador(int trabajadorId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cita>> AddCita(Cita cita)
        {
            
            var sql = @"INSERT INTO Citas (CitaID, ClienteID, Notas, TrabajadorID) 
                   VALUES (@CitaID, @ClienteID, @Notas, @TrabajadorID);
                   SELECT CAST(SCOPE_IDENTITY() as int)";

            var citaId = await _dbconnection.ExecuteScalarAsync<int>(sql, new
            {
                CitaID = cita.CitaID,
                ClienteID = cita.ClienteID,
                Notas = cita.Notas,
                TrabajadorID = cita.TrabajadorID
            });

            return (IEnumerable<Cita>)await GetCitaById(citaId);

        }

        public Task UpdateCita(Cita cita)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCita(int id)
        {
            throw new NotImplementedException();
        }
    }
}