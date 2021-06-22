
using System.Collections.Generic;

namespace Secretariat.Infra.Domain.Models
{
    public class EmployéEntity : PersonneEntity
    {
        public double Salaire { get; set; }

        public virtual ICollection<RéunionEntity> Réunions { get; set; }

    }
}
