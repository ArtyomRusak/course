using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.InterfaceRepository;
using DataLayer.DBContext;

namespace DataLayer.Repositories
{
    public class Repository : IRepository
    {
        protected BankContext Context;

        public Repository(BankContext context)
        {
            Context = context;
        }
    }
}
