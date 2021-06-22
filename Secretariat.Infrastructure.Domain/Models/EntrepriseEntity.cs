
namespace Secretariat.Infra.Domain.Models
{
    public class EntrepriseEntity
    {
        public long IdEntreprise { get; set; }
        public string Nom { get; set; }

        public virtual ContactEntity Contact { get; set; }

    }
}
