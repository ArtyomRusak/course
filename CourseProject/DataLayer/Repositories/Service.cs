using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public abstract class Service<T>
    {
        public abstract void Add(T value);
        public abstract void Remove(int id);
        public abstract T GetEntityById(int id);
        public abstract void Save();
    }
}
