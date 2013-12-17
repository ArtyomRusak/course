using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject.Core;
using CourseProject.Core.Entities;
using CourseProject.Infrastructure.Guard.Validation;
using CourseProject.Services.Exceptions;

namespace CourseProject.Services.Services
{
    public class HistoryService : IService
    {
        #region [Private members]

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositories;

        #endregion


        #region [Ctor's]

        public HistoryService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositories = factoryOfRepositories;
        }

        #endregion


        #region [HistoryService's members]

        public History CreateRecord(string message, int customerId)
        {
            Guard.AgainstEmptyStringOrNull(message, "message");

            var record = new History
            {
                Content = message,
                CustomerId = customerId
            };
            var historyRepository = _factoryOfRepositories.GetHistoryRepository();
            historyRepository.Create(record);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception exception)
            {
                throw new ServiceException(exception);
            }

            return record;
        }

        public List<History> GetRecordsByCustomerId(int customerId)
        {
            var historyRepository = _factoryOfRepositories.GetHistoryRepository();
            return historyRepository.Filter(e => e.CustomerId == customerId).ToList();
        }

        #endregion
    }
}
