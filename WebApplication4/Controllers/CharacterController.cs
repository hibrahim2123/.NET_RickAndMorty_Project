using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Core.Application.Features.CORS.Queries;
using WebApplication4.Core.Application.Interfaces;
using WebApplication4.Core.Domain.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper mapper;
        public CharacterController(IRepository<Character> repository,IMapper mapper)
        {
            this._characterRepository = repository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<List<Character>> List()
        {
            var data = await this._characterRepository.GetAllAsync();
            return this.mapper.Map<List<Character>>(data);
        }

        [HttpGet("{id}")]
        public async Task<Character> Get(int id)
        {
            var data = await this._characterRepository.GetByIdAsync(id);
             return this.mapper.Map<Character>(data);
        }
        
    }
}
