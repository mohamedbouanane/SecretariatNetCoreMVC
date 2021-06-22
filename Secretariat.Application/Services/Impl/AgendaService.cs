
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Presentation.Services.Impl
{
    public class AgendaService : Service<int, AgendaEntity, IAgendaRepository>, IAgendaService
    {
        public AgendaService(IAgendaRepository repository) : base(repository) { }

    }
}
