using GP.Data.Infrastructure;
using GP.Domain.Entities;
using GP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Service
{
    public class ClientService : EntityService<Client>, IClientService
    {
        public ClientService(IUnitOfWork _utwk, IRepositoryBase<Client> _repository) : base(_utwk, _repository)
        {
        }
    }
}
