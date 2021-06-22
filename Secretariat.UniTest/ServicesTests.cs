using NUnit.Framework;
using Secretariat.Presentation.Services;
using Microsoft.EntityFrameworkCore;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using Secretariat.Presentation.Context;
using Secretariat.Presentation.Services.Impl;
using Secretariat.Infra.Data.Repositories.Impl;
using Secretariat.Infra.Data.Repositories;
using Secretariat.Infra.Domain.Models;

namespace Secretariat.UniTest
{
    public class ServicesTests
    {
        DbContext context;

        IAgendaService agendaService;
        IEmploy�Service employ�Service;
        IEntrepriseService entrepriseService;
        IPersonneService personneService;
        IRendezvousService rendezvousService;
        IR�unionService r�unionService;
        IVisiteService visiteService;


        [SetUp]
        public void Setup()
        {
            context = new SecretariatContext();

            agendaService = new AgendaService(new AgendaRepository(context));
            employ�Service = new Employ�Service(new Employ�Repository(context));
            entrepriseService = new EntrepriseService(new EntrepriseRepository(context));
            personneService = new PersonneService(new PersonneRepository(context));
            rendezvousService = new RendezvousService(new RendezvousRepository(context));
            r�unionService = new R�unionService(new R�unionRepository(context));
            visiteService = new VisiteService(new VisiteRepository(context));
        }

        [Test]
        public async Task InsertFakeDataAgendaAsyncTest()
        {
            for (int i = 0; i < 30; i++)
                await agendaService.SaveAsync(
               new AgendaEntity() { 
                   Login=Faker.Name.First(),
                   MotdePass=Faker.Name.Last() 
               });
            await context.SaveChangesAsync();
        }

        [Test]
        public async Task InsertFakeDataVisiteAsyncTest()
        {

        }

        [Test]
        public async Task InsertFakeDataPersonneAsyncTest()
        {
            
        }

        [Test]
        public async Task InsertFakeDataEmploy�AsyncTest()
        {

        }

        [Test]
        public async Task InsertFakeDataEntrepriseAsyncTest()
        {

        }
    }
}