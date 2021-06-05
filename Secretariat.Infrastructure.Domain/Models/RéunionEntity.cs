
using System.Collections.Generic;

namespace Secretariat.Infra.Domain.Models
{
    public class RéunionEntity : EvenementEntity
    {
        public virtual ICollection<EmployéEntity> Employés { get; set; }

    }
}
