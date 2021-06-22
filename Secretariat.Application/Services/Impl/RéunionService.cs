
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Presentation.Services.Impl
{
    public class RéunionService : Service<long, RéunionEntity, IRéunionRepository>, IRéunionService
    {
        public RéunionService(IRéunionRepository repository) : base(repository) { }

    }
}
