using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Service
{
    public class VoitureService : EntityService<Voiture>, IVoitureService
    {
        public VoitureService(IUnitOfWork _utwk, IRepositoryBase<Voiture> _repository) : base(_utwk, _repository)
        {
        }
    }
}
