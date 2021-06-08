
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.App.Services.Impl
{
    public class RendezvousService : Service<long, RendezvousEntity, IRendezvousRepository>, IRendezvousService
    {
        public RendezvousService(IRendezvousRepository repository) : base(repository) { }

    }
}
