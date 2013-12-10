using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Exceptions;
using Core;
using Core.Entities;
using Infrastructure.Guard.Validation;

namespace BusinessLogicLayer.Services
{
    public class DepositService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public DepositService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion

        #region [DepositService's members]

        public Deposit CreateDeposit(double startSummary, int customerId, int currencyId, int optionDepositId)
        {
            Guard.AgainstNegatives((int) startSummary);

            var deposit = new Deposit
            {
                CreateDate = DateTime.Now,
                OpeningSummary = startSummary,
                Summary = startSummary,
                CustomerId = customerId,
                CurrencyId = currencyId,
                OptionDepositId = optionDepositId
            };

            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            depositRepository.Create(deposit);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception exception)
            {
                throw new ServiceException(exception);
            }

            return deposit;
        }

        public void UpdateDeposit(Deposit deposit)
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            try
            {
                depositRepository.Update(deposit);
            }
            catch (Exception ex)
            {
                throw new DepositServiceException(ex);
            }
        }

        public void RemoveDeposit(Deposit deposit)
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            depositRepository.Remove(deposit);
        }

        public List<Deposit> GetDepositsByCustomerId(int customerId)
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            return depositRepository.Filter(e => e.CustomerId == customerId).ToList();
        }

        public int GetCountOfAllDeposits()
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            return depositRepository.All().Count();
        }

        #endregion

    }
}
