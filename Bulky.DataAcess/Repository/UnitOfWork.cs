using Bulky.DataAcess.Data;
using Bulky.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category {  get; private set; }
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
