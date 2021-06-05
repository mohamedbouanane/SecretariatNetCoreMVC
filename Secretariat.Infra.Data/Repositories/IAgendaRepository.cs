using DynamicRepository;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories
{
    public interface IAgendaRepository : IRepository<int, AgendaEntity>
    {

    }
}
