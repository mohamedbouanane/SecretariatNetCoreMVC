
using System.Collections.Generic;

namespace Secretariat.Infra.Domain.Models
{
    public class ClientEntity : PersonneEntity
    {
        public virtual ICollection<RendezvousEntity> Rendezvouss { get; set; }

    }
}
