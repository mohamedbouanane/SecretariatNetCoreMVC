using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class RendezvousRepository : Repository<long, RendezvousEntity>, IRendezvousRepository
    {
        public RendezvousRepository(DbContext context) : base(context) { }

    }
}
