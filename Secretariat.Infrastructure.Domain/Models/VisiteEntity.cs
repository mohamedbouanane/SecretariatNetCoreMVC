
namespace Secretariat.Infra.Domain.Models
{
    public class VisiteEntity : EvenementEntity
    {
        public string RapportVisite { get; set; }

        public virtual EntrepriseEntity Entreprise { get; set; }

    }
}
