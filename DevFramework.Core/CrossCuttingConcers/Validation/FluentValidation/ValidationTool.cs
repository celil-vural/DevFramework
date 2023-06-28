using DevFramework.Northwind.Entities.Abstract;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace DevFramework.Core.CrossCuttingConcers.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void FluentValidate<T>(AbstractValidator<T> validator, T entity) where T : class, IEntity, new()
        {
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    throw new ValidationException(error.ErrorMessage);
                }
            }
        }
    }
}
