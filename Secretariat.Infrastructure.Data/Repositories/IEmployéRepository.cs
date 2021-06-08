using DynamicRepository;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Infra.Data.Repositories
{
    public interface IEmployéRepository : IRepository<long, EmployéEntity>
    {
    }
}
