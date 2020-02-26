using System.Threading.Tasks;
using Travel.Application.Core.SharedKernel;

namespace Travel.Application.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}