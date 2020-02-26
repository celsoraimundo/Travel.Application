using Travel.Application.Core.Entities;
using Travel.Application.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Travel.Application.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public List<Viagem> Viagens { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Viagens = _repository.List<Viagem>();
        }
    }
}
