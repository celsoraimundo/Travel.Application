using Autofac;
using Autofac.Extensions.DependencyInjection;
using Travel.Application.Core;
using Travel.Application.SharedKernel.Interfaces;
using Travel.Application.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Travel.Application.Infrastructure
{
    public static class ContainerSetup
    {
        public static IServiceProvider InitializeWeb(Assembly webAssembly, IServiceCollection services) =>
            new AutofacServiceProvider(BaseAutofacInitialization(setupAction =>
            {
                setupAction.Populate(services);
                setupAction.RegisterAssemblyTypes(webAssembly).AsImplementedInterfaces();
            }));

        public static IContainer BaseAutofacInitialization(Action<ContainerBuilder> setupAction = null)
        {
            var builder = new ContainerBuilder();

            var coreAssembly = Assembly.GetAssembly(typeof(DatabasePopulator));
            var infrastructureAssembly = Assembly.GetAssembly(typeof(EfRepository));
            var sharedKernelAssembly = Assembly.GetAssembly(typeof(IRepository));
            builder.RegisterAssemblyTypes(sharedKernelAssembly, coreAssembly, infrastructureAssembly).AsImplementedInterfaces();

            setupAction?.Invoke(builder);
            return builder.Build();
        }
    }
}
