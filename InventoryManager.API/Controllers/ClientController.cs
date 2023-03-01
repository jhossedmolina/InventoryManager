using AutoMapper;
using InventoryManager.Core.DTOs;
using InventoryManager.Core.Entities;
using InventoryManager.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var clients = await _clientRepository.GetClients();
            var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients);
            return Ok(clientsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await _clientRepository.GetClient(id);
            var clientDto = _mapper.Map<ClientDto>(client);
            return Ok(clientDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostClient(ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);
            await _clientRepository.PostClient(client);
            return Ok(client);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClient(int id, ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);
            client.Id = id;
            await _clientRepository.PutClient(client);
            return Ok(client);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var result = await _clientRepository.DeleteClient(id);
            return Ok(result);
        }
    }
}
