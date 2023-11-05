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
    public class EpisodeController : ControllerBase
    {
        private readonly IRepository<Episode> _episodeRepository;
        private readonly IMapper mapper;
        public EpisodeController(IRepository<Episode> repository, IMapper mapper)
        {
            this._episodeRepository = repository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<List<Character>> List()
        {
            var data = await this._episodeRepository.GetAllAsync();
            return this.mapper.Map<List<Character>>(data);
        }

        [HttpGet("{id}")]
        public async Task<Character> Get(int id)
        {
            var data = await this._episodeRepository.GetByIdAsync(id);
            return this.mapper.Map<Character>(data);
        }



    }
}
