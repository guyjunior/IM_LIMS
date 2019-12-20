using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces.Repositories;
using Lims.Domain.Services;

namespace Lims.Infra.Repositories
{
    public class AmostraMemDB : IAmostraRepository
    {
        public ICollection<Amostra> Amostras = new List<Amostra>();

        bool IRepository<Amostra>.Delete(Amostra sample)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Amostra>.Create(Amostra sample)
        {
            throw new NotImplementedException();
        }

              
        Amostra IRepository<Amostra>.Read(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Amostra> IRepository<Amostra>.ReadAll()
        {
            throw new NotImplementedException();
        }

        bool IRepository<Amostra>.Update(Amostra sample)
        {
            throw new NotImplementedException();
        }
    }
}
