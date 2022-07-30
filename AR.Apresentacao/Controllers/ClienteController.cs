using AR.Domain;
using AR.Infra.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AR.Apresentacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _repository;

        public ClienteController(ClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Cliente cliente)
        {
            try
            {
                await _repository.Add(cliente);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
