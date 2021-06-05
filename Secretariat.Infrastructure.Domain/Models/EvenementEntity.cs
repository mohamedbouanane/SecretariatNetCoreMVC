
using System;

namespace Secretariat.Infra.Domain.Models
{
    public class EvenementEntity
    {
        public long IdEvenement { get; set; }
        public string TitreEvenement { get; set; }
        public DateTime DateEvent { get; set; }
        public DateTime TimeEvent { get; set; }
        public string Description { get; set; }

        public virtual AgendaEntity Agenda { get; set; }

    }
}
