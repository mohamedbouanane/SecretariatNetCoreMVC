
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.App.Services.Impl
{
    public class VisiteService : Service<long, VisiteEntity, IVisiteRepository>, IVisiteService
    {
        public VisiteService(IVisiteRepository repository) : base(repository) { }

    }
}
