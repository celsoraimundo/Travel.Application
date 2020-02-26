using Travel.Application.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Travel.Application.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=NOTE-DELL;Database=TravelDB;Trusted_Connection=True;"));
    }
}
