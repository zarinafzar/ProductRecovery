using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;

namespace Data.Interfaces
{
    public interface IUnits:IDisposable
    {
        IEnumerable<Unit> GetAll();
        void Add(Unit model);
        void Edit(Unit model);
        void Delete(int id);
        void Trash(int id,bool status);
        bool IsExist(string name);
        void Save();

    }
}
