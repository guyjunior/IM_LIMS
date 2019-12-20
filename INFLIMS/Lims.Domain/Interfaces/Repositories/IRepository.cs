using System;
using System.Collections.Generic;
using System.Text;
using Lims.Domain.Entities;
using Lims.Domain.Interfaces;
using Lims.Domain.Services;

namespace Lims.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Create(T sample);

        T Read(Guid id);
        IEnumerable<T> ReadAll();
        bool Update(T sample);
        
        bool Delete(T sample);

    }
}
