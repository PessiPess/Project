using DAL.Domain;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    class ShopRepository : IRepository<Shop>
    {
        private ShopContext db;

        public ShopRepository(ShopContext context)
        {
            this.db = context;
        }

        public IEnumerable<Shop> GetAll()
        {
            return db.Shops;
        }

        public Shop Get(int id)
        {
            return db.Shops.Find(id);
        }

        public void Create(Shop shop)
        {
            db.Shops.Add(shop);
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
        }
        public IEnumerable<Shop> Find(Func<Shop, Boolean> predicate)
        {
            return db.Shops.Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);
            if (shop != null)
                db.Shops.Remove(shop);
        }
    }
}
