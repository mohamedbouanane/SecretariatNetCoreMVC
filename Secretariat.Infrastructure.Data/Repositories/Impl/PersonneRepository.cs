using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class PersonneRepository : Repository<long, PersonneEntity>, IPersonneRepository
    {
        public PersonneRepository(DbContext context) : base(context) { }
    }
}
