
using DynamicRepository.EFCore;
using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories.Impl
{
    public class EmployéRepository : Repository<long, EmployéEntity>, IEmployéRepository
    {
        public EmployéRepository(DbContext context) : base(context) { }

    }
}
