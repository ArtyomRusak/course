using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Core.Exceptions;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class OptionDepositService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        public OptionDepositService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        public List<OptionDeposit> GetOptionDeposits()
        {
            var optionDepositRepository = _factoryOfRepositories.GetOptionDepositRepository();
            return optionDepositRepository.All().ToList();
        }

        public OptionDeposit GetOptionDepositByName(string name)
        {
            var optionDepositRepository = _factoryOfRepositories.GetOptionDepositRepository();
            try
            {
                return optionDepositRepository.Find(e => e.Name == name);
            }
            catch (RepositoryException e)
            {
                throw new OptionDepositServiceException(e.Message);
            }
        }
    }
}
