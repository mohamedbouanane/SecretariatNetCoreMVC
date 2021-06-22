
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Presentation.Services.Impl
{
    public class EmployéService : Service<long, EmployéEntity, IEmployéRepository>, IEmployéService
    {
        public EmployéService(IEmployéRepository repository) : base(repository) { }

    }
}
