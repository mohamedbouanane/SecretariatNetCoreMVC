
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Presentation.Services.Impl
{
    public class EntrepriseService : Service<long, EntrepriseEntity, IEntrepriseRepository>, IEntrepriseService
    {
        public EntrepriseService(IEntrepriseRepository repository) : base(repository) { }

    }
}
