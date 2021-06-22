
namespace Secretariat.Infra.Domain.Models
{
    public class PersonneEntity
    {
        public long IdPersonne { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }

        public virtual ContactEntity Contact { get; set; }

    }
}
