using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;
using Data.Interfaces;

namespace Data.Repositories
{
    public class UnitsRepo: IUnits
    {
        private readonly prDbEntities _ctx;

        public UnitsRepo(prDbEntities ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Unit> GetAll()
        {
            return _ctx.Units.ToList();
        }

        public void Add(Unit model)
        {
            throw new NotImplementedException();
        }

        public void Edit(Unit model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Trash(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string name)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx?.Dispose();
        }
    }
}
