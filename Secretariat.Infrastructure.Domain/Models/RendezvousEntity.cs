
namespace Secretariat.Infra.Domain.Models
{
    public class RendezvousEntity : EvenementEntity
    {
        public virtual PersonneEntity Personne { get; set; }

    }
}
