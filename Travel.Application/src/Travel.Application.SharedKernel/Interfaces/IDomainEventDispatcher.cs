using System.Threading.Tasks;
using Travel.Application.Core.SharedKernel;

namespace Travel.Application.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}