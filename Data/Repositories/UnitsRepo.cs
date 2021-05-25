using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;
using Data.Interfaces;
using Data.Models;

namespace Data.Repositories
{
    public class UnitsRepo: IUnits
    {
        private readonly Context _ctx;

        public UnitsRepo(Context ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Units> GetAll()
        {
            return _ctx.Units.ToList();
        }

        public void Add(Units model)
        {
            _ctx.Units.Add(model);
            Save();
        }

        public void Edit(Units model)
        {
            var tbl = _ctx.Units.Find(model.Id);
            if (tbl != null) _ctx.Units.Attach(tbl);
            Save();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Trash(int id, bool status)
        {
            var tbl = _ctx.Units.Find(id);
            if (tbl != null) _ctx.Units.Attach(tbl);
            Save();
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
