﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer.Repositories.Contracts
{
    public interface IAccountRepository
    {
        List<Account> GetAccountsByCustomerId(int id);
    }
}