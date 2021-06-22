
using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class AgendaRepository : Repository<int, AgendaEntity>, IAgendaRepository
    {
        public AgendaRepository(DbContext context) : base(context) { }

    }
}
