using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shop> Shops { get; }
       
        void Save();
    }
}
