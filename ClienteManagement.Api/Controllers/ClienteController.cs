using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClienteManagement.Domain.Entities;
using ClienteManagement.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClienteManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get()
        {
            return await _clienteRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Cliente> Get(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
            await _clienteRepository.AddAsync(cliente);
            return CreatedAtAction(nameof(Get), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            await _clienteRepository.UpdateAsync(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _clienteRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
