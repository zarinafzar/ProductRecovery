using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;
using Data.Models;

namespace Data.Interfaces
{
    public interface IUnits:IDisposable
    {
        IEnumerable<Units> GetAll();
        void Add(Units model);
        void Edit(Units model);
        void Delete(int id);
        void Trash(int id,bool status);
        bool IsExist(string name);
        void Save();

    }
}
