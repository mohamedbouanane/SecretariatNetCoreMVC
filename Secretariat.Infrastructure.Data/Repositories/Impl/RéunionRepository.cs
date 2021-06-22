
using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class RéunionRepository : Repository<long, RéunionEntity>, IRéunionRepository
    {
        public RéunionRepository(DbContext context) : base(context) { }

    }
}
