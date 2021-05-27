using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace Data.Contexts
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context ctx = new Context();

        private GenericRepository<Units> _unitsRepo;
        public GenericRepository<Units> UnitsRepo => _unitsRepo ?? (_unitsRepo = new GenericRepository<Units>(ctx));

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx?.Dispose();
        }
    }
}
