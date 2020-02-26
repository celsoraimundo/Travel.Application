using Travel.Application.Core.Entities;
using Travel.Application.SharedKernel.Interfaces;
using System.Linq;

namespace Travel.Application.Core
{
    public static class DatabasePopulator
    {
        public static int PopulateDatabase(IRepository todoRepository)
        {
            if (todoRepository.List<Viagem>().Count() >= 5) return 0;

            //todoRepository.Add(new Viagem
            //{
            //    Title = "Get Sample Working",
            //    Description = "Try to get the sample to build."
            //});
            //todoRepository.Add(new Viagem
            //{
            //    Title = "Review Solution",
            //    Description = "Review the different projects in the solution and how they relate to one another."
            //});
            //todoRepository.Add(new Viagem
            //{
            //    Title = "Run and Review Tests",
            //    Description = "Make sure all the tests run and review what they are doing."
            //});

            return todoRepository.List<Viagem>().Count;
        }
    }
}
