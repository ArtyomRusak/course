using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class CurrencyService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public CurrencyService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion

        #region [CurrencyService's members]

        public List<Currency> GetCurrencies()
        {
            var currencyRepository = _factoryOfRepositories.GetCurrencyRepository();
            return currencyRepository.All().ToList();
        }

        public Currency GetCurrencyByValue(string value)
        {
            var currencyRepository = _factoryOfRepositories.GetCurrencyRepository();
            try
            {
                return currencyRepository.Find(e => e.Value == value);
            }
            catch (RepositoryException ex)
            {
                throw new CurrencyServiceException(ex.Message);
            }
        }

        #endregion
    }
}
