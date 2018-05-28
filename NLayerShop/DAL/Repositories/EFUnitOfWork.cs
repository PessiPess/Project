using DAL.Domain;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ShopContext db;
        private ShopRepository shopRepository;
        

        public EFUnitOfWork(string connectionString)
        {
            db = new ShopContext(connectionString);
        }
        public IRepository<Shop> Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(db);
                return shopRepository;
            }
        }

       

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
