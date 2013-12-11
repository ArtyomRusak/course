using CourseProject.Core.Entities;
using CourseProject.Infrastructure.Guard.Validation;

namespace CourseProject.Services.Validators
{
    public class CustomerValidator : IValidate
    {
        private Customer _customer;

        public CustomerValidator(Customer customer)
        {
            Guard.AgainstNullReference(customer, "account");

            _customer = customer;
        }

        #region Implementation of IValidate

        public void Validate()
        {
            Guard.AgainstEmptyStringOrNull(_customer.Name);
            Guard.AgainstEmptyStringOrNull(_customer.Surname);
            Guard.AgainstEmptyStringOrNull(_customer.Patronymic);
            Guard.AgainstEmptyStringOrNull(_customer.PassportData);
            Guard.AgainstNullReference(_customer.BirthDate);
            Guard.AgainstEmptyStringOrNull(_customer.Address);
        }

        #endregion
    }
}
