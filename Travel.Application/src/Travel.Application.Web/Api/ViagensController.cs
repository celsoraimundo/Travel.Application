using Travel.Application.Core.Entities;
using Travel.Application.SharedKernel.Interfaces;
using Travel.Application.Web.ApiModels;
using Travel.Application.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Travel.Application.Web.Api
{
    public class ViagensController : BaseApiController
    {
        private readonly IRepository _repository;

        public ViagensController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public IActionResult List()
        {
            var items = _repository.List<Viagem>()
                            .Select(ViagemDTO.From);
            return Ok(items);
        }

        // GET: api/ToDoItems
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var item = ViagemDTO.From(_repository.GetById<Viagem>(id));
            return Ok(item);
        }

        // POST: api/ToDoItems
        [HttpPost]
        public IActionResult Post([FromBody] ViagemDTO item)
        {
            var viagem = new Viagem()
            {
                NomePassageiro = item.NomePassageiro,
                Origem = item.Origem,
                Destino = item.Destino,
                DataPartida = item.DataPartida
            };
            _repository.Add(viagem);
            return Ok(ViagemDTO.From(viagem));
        }

    }
}
