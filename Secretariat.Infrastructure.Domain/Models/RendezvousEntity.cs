
namespace Secretariat.Infra.Domain.Models
{
    public class RendezvousEntity : EvenementEntity
    {
        public virtual ClientEntity Client { get; set; }

    }
}
