
using System.Collections.Generic;

namespace Secretariat.Infra.Domain.Models
{
    public class AgendaEntity
    {
        public int IdAgenda { get; set; }
        public string Login { get; set; }
        public string MotdePass { get; set; }

        public virtual ICollection<EvenementEntity> Evenements { get; set; }

    }
}
