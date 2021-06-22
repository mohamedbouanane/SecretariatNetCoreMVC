using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.Presentation.Context
{
    public class SecretariatContext : DbContext
    {
        #region DbSets
        public DbSet<AgendaEntity> Agendas { get; set; }
        //public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<EvenementEntity> Evenements { get; set; }
        //public DbSet<RendezvousEntity> Rendezvouss { get; set; }
        //public DbSet<RéunionEntity> Réunions { get; set; }
        //public DbSet<VisiteEntity> Visites { get; set; }
        //public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<PersonneEntity> Personnes { get; set; }
        //public DbSet<EmployéEntity> Employés { get; set; }
        public DbSet<EntrepriseEntity> Entreprises { get; set; }
        #endregion DbSets

        public SecretariatContext() { }

        public SecretariatContext(DbContextOptions<SecretariatContext> options) : base(options) { }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config Entitys with Fluent API
            // Doc -> https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx

            // SQL nams conventions 
            // -> https://www.sqlshack.com/learn-sql-naming-conventions/

            var agenda = modelBuilder.Entity<AgendaEntity>();
            var client = modelBuilder.Entity<ClientEntity>();
            var contact = modelBuilder.Entity<ContactEntity>();
            var employé = modelBuilder.Entity<EmployéEntity>();
            var entreprise = modelBuilder.Entity<EntrepriseEntity>();
            var evenement = modelBuilder.Entity<EvenementEntity>();
            var personne = modelBuilder.Entity<PersonneEntity>();
            var rendezvous = modelBuilder.Entity<RendezvousEntity>();
            var réunion = modelBuilder.Entity<RéunionEntity>();
            var visite = modelBuilder.Entity<VisiteEntity>();

            #region AgendaEntity model config
            agenda.ToTable("agenda")
                .HasKey(p => p.IdAgenda);
            //.HasName("pk_agenda");

            agenda.HasMany(p => p.Evenements)
                .WithOne(p => p.Agenda)
                .HasForeignKey("evenement_agenda_id") // Shadow property ??????
                .HasConstraintName("evenement_agenda_fk")
                .OnDelete(DeleteBehavior.Cascade);

            agenda.Property(p => p.IdAgenda)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            agenda.Property(p => p.MotdePass)
                .HasColumnName("mot_de_pass")
                .HasMaxLength(50)
                .IsRequired();

            agenda.Property(p => p.Login)
                .HasColumnName("login")
                .HasMaxLength(50)
                .IsRequired();
            #endregion

            #region ClientEntity model config
            client.ToTable("client");
            #endregion

            #region ContactEntity model config
            contact.ToTable("contact")
                .HasKey(p => p.IdContact);
                //.HasName("pk_contact");

            contact.Property(p => p.IdContact)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            contact.Property(p => p.Tel)
                .HasColumnName("tel");

            contact.Property(p => p.Adresse)
                .HasColumnName("adresse");

            contact.Property(p => p.Email)
                .HasColumnName("email");
            #endregion

            #region EmployéEntity model config
            employé.ToTable("employé");

            employé.Property(p => p.Salaire)
                .HasColumnName("salaire");
            #endregion

            #region EntrepriseEntity model config
            entreprise.ToTable("entreprise")
                .HasKey(p => p.IdEntreprise);
            //.HasName("pk_entreprise");

            entreprise.HasOne(p => p.Contact);
            //.WithOne(""); // Shadow property

            entreprise.Property(p => p.IdEntreprise)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            entreprise.Property(p => p.Nom)
                .HasColumnName("nom")
                .IsRequired();
            #endregion

            #region EvenementEntity model config
            evenement.ToTable("evenement")
                .HasKey(p => p.IdEvenement);
                //.HasName("pk_evenement");

            evenement.Property(p => p.IdEvenement)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            evenement.Property(p => p.TitreEvenement)
                .HasColumnName("evenement_titre")
                .IsRequired();

            evenement.Property(p => p.DateEvent)
                .HasColumnName("evenement_date");

            evenement.Property(p => p.TimeEvent)
                .HasColumnName("evenement_time");

            evenement.Property(p => p.Description)
                .HasColumnName("description");
            #endregion

            #region PersonneEntity model config
            personne.ToTable("personne")
                .HasKey(p => p.IdPersonne);
                //.HasName("pk_personne");

            personne.HasOne(p => p.Contact);
                //.WithOne("")
                //.OnDelete(DeleteBehavior.Cascade);

            personne.Property(p => p.IdPersonne)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            personne.Property(p => p.Nom)
                .HasColumnName("nom");

            personne.Property(p => p.Prénom)
                .HasColumnName("prénom");
            #endregion

            #region RendezVousEntity model config
            rendezvous.ToTable("rendezvous")
                .HasOne(p => p.Client)
                .WithMany(p => p.Rendezvouss)
                .HasForeignKey("rendezvous_client_id") // Shadow property
                .HasConstraintName("endezvous_client_fk")
                .OnDelete(DeleteBehavior.Cascade); //!
            #endregion

            #region RéunionEntity model config
            réunion.ToTable("réunion")
                .HasMany(p => p.Employés)
                .WithMany(p => p.Réunions);
            #endregion

            #region VisiteEntity model config
            visite.ToTable("visite")
                .HasOne(p => p.Entreprise);
            //.WithMany("visite_entreprise_id")
            //.HasConstraintName("visite_entreprise_fk")
            //.OnDelete(DeleteBehavior.Cascade); //!

            visite.Property(p => p.RapportVisite)
                .HasColumnName("rapport_visite");
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
