using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Infra.Interfaces
{
    // Interface é como um contrato é quem herda é a classe "ClienteRepository"
    // e precisamos injetar 
    public interface IClienteRespository
    {
        IQueryable<Cliente> GetAll();

        Task Add(Cliente entity);
    }
}
