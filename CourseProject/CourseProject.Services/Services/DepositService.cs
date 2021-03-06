﻿using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class DepositService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        public DepositService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

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

        public Deposit GetDepositById(int depositId)
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            try
            {
                return depositRepository.GetEntityById(depositId);
            }
            catch (RepositoryException ex)
            {
                throw new DepositServiceException(ex.Message);
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

        public IQueryable<Deposit> GetAllDeposits()
        {
            var depositRepository = _factoryOfRepositories.GetDepositRepository();
            return depositRepository.All();
        }
    }
}
