using Microsoft.EntityFrameworkCore;
using Secretariat.Infra.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secretariat.Infra.Data.Context
{
    public class SecretariatContext : DbContext
    {
        public DbSet<AgendaEntity> Agendas { get; set; }
        public DbSet<EvenementEntity> Evenements { get; set; }
        public DbSet<RendezvousEntity> Rendezvouss { get; set; }
        public DbSet<RéunionEntity> Réunions { get; set; }
        public DbSet<VisiteEntity> Visites { get; set; }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<PersonneEntity> Personnes { get; set; }
        public DbSet<EmployéEntity> Employés { get; set; }
        public DbSet<EntrepriseEntity> Entreprises { get; set; }


        public SecretariatContext(DbContextOptions<SecretariatContext> options) : base(options) { }

        // Config Entitys with Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var agenda = modelBuilder.Entity<AgendaEntity>();

            var evenement = modelBuilder.Entity<EvenementEntity>();
            var rendezvous = modelBuilder.Entity<RendezvousEntity>();
            var réunion = modelBuilder.Entity<RéunionEntity>();
            var visite = modelBuilder.Entity<VisiteEntity>();
            
            var contact = modelBuilder.Entity<ContactEntity>();
            var personne = modelBuilder.Entity<PersonneEntity>();
            var employé = modelBuilder.Entity<EmployéEntity>();
            var entreprise = modelBuilder.Entity<EntrepriseEntity>();

            // Agenda
            agenda.HasKey(p => p.IdAgenda);
            agenda.Property(p => p.IdAgenda).ValueGeneratedOnAdd();
            agenda.HasMany(p => p.Evenements).WithOne(p => p.Agenda);

            base.OnModelCreating(modelBuilder);
            //MessageBox.Show("Database generated...");
            // Evenement
            evenement.HasKey(p => p.IdEvenement);
            evenement.Property(p => p.IdEvenement).ValueGeneratedOnAdd();

            // Contact
            contact.HasKey(p => p.IdContact);
            contact.Property(p => p.IdContact).ValueGeneratedOnAdd();

            // Visite
            visite.HasOne(p => p.Entreprise);

            // RendezVous
            rendezvous.HasOne(p=>p.Personne);

            // Réunion
            réunion.HasMany(p => p.Employés);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = DESKTOP-5SSJU0Q; Initial Catalog = BibliothèqueUniversitaire; Integrated Security = True";

            //optionsBuilder.UseSqlServer(connectionString);
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
