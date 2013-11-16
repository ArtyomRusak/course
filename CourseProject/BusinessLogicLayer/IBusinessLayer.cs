using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IBusinessLayer<T>
    {
        void AddEntity(T value);
        void RemoveEntity(int id);
        void UpdateEntity(T value);
        T GetEntityById(int id);
        void Save();
    }
}
