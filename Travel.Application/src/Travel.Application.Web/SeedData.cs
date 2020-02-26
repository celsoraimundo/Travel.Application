using Travel.Application.Core.Entities;
using Travel.Application.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Travel.Application.Web
{
    public static class SeedData
    {
        //public static readonly Viagem ToDoItem1 = new Viagem
        //{
        //    Title = "Get Sample Working",
        //    Description = "Try to get the sample to build."
        //};
        //public static readonly Viagem ToDoItem2 = new Viagem
        //{
        //    Title = "Review Solution",
        //    Description = "Review the different projects in the solution and how they relate to one another."
        //};
        //public static readonly Viagem ToDoItem3 = new Viagem
        //{
        //    Title = "Run and Review Tests",
        //    Description = "Make sure all the tests run and review what they are doing."
        //};

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
            {
                // Look for any TODO items.
                if (dbContext.Viagem.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);


            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Viagem)
            {
                dbContext.Remove(item);
            }
            dbContext.SaveChanges();
            //dbContext.ToDoItems.Add(ToDoItem1);
            //dbContext.ToDoItems.Add(ToDoItem2);
            //dbContext.ToDoItems.Add(ToDoItem3);

            dbContext.SaveChanges();
        }
    }
}
