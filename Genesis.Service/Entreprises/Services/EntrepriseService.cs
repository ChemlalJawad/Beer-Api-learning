﻿using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Entreprises.Services.Interfaces;
using Genesis.Data.Repositories.Interfaces;

namespace Genesis.Service.Entreprises.Services
{
    public class EntrepriseService : IEntrepriseService
    {
        private readonly IEntrepriseRepository _entrepriseRepository;
        public EntrepriseService(IEntrepriseRepository entrepriseRepository)
        {
            _entrepriseRepository = entrepriseRepository;
        }
        public Entreprise CreateEntreprise(CreateEntrepriseCommand command)
        {
            
            var entreprise = new Entreprise {
                Adresses = command.Adresses,
                NumeroTva = command.NumeroTva,
                SiegeSocial = command.SiegeSocial
            };
            _entrepriseRepository.CreateEnt(entreprise);

            return entreprise;
        }

        public void HireContact(HireContactCommand command)
        {
            var contactEntreprise = new ContactEntreprise {
               ContactId = command.ContactId,
               EntrepriseId = command.EntrepriseId
            };

            _entrepriseRepository.HireContact(contactEntreprise);
        }
    }
}
