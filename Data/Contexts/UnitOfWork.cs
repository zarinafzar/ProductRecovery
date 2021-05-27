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

        private GenericRepository<Categories> _categoriesRepo;
        public GenericRepository<Categories> CategoriesRepo => _categoriesRepo ?? (_categoriesRepo = new GenericRepository<Categories>(ctx));

        private GenericRepository<Pomps> _pompsRepo;
        public GenericRepository<Pomps> PompsRepo => _pompsRepo ?? (_pompsRepo = new GenericRepository<Pomps>(ctx));

        private GenericRepository<PompsEvents> _pompsEventsRepo;
        public GenericRepository<PompsEvents> PompsEventsRepo => _pompsEventsRepo ?? (_pompsEventsRepo = new GenericRepository<PompsEvents>(ctx));

        private GenericRepository<RuntimeTasks> _runtimeTasksRepo;
        public GenericRepository<RuntimeTasks> RuntimeTasksRepo => _runtimeTasksRepo ?? (_runtimeTasksRepo = new GenericRepository<RuntimeTasks>(ctx));

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
