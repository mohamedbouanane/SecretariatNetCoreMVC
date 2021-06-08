
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.App.Services.Impl
{
    public class EntrepriseService : Service<long, EntrepriseEntity, IEntrepriseRepository>, IEntrepriseService
    {
        public EntrepriseService(IEntrepriseRepository repository) : base(repository) { }

    }
}
