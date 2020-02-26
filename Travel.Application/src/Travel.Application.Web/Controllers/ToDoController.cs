using Travel.Application.Core;
using Travel.Application.Core.Entities;
using Travel.Application.SharedKernel.Interfaces;
using Travel.Application.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Travel.Application.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository _repository;

        public ToDoController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var items = _repository.List<Viagem>()
                            .Select(ViagemDTO.From);
            return View(items);
        }

        public IActionResult Populate()
        {
            int recordsAdded = DatabasePopulator.PopulateDatabase(_repository);
            return Ok(recordsAdded);
        }
    }
}
