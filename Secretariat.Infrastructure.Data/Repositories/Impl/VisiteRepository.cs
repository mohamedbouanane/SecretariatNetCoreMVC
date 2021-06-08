using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class VisiteRepository : Repository<long, VisiteEntity>, IVisiteRepository
    {
        public VisiteRepository(DbContext context) : base(context) { }

    }
}
