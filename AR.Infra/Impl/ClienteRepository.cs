using AR.Domain;
using AR.Infra.Interfaces;

namespace AR.Infra.Impl
{
    public class ClienteRepository : IClienteRespository
    {
        private readonly ContextPrincipal _db;

        public ClienteRepository(ContextPrincipal db)
        {
            _db = db;
        }

        public async Task Add(Cliente entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Clientes;
        }
    }
}
