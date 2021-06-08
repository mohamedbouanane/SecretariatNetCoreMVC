
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.App.Services.Impl
{
    public class EmployéService : Service<long, EmployéEntity, IEmployéRepository>, IEmployéService
    {
        public EmployéService(IEmployéRepository repository) : base(repository) { }

    }
}
