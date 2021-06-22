
using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class EntrepriseRepository : Repository<long, EntrepriseEntity>, IEntrepriseRepository
    {
        public EntrepriseRepository(DbContext context) : base(context) { }
    }
}
