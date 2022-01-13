using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Service
{
    public class ChauffeurService : EntityService<Chauffeur>, IChauffeurService
    {
        public ChauffeurService(IUnitOfWork _utwk, IRepositoryBase<Chauffeur> _repository) : base(_utwk, _repository)
        {
        }
    }
}
