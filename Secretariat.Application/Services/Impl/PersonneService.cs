
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.App.Services.Impl
{
    public class PersonneService : Service<long, PersonneEntity, IPersonneRepository>, IPersonneService
    {
        public PersonneService(IPersonneRepository repository) : base(repository) { }

    }
}
