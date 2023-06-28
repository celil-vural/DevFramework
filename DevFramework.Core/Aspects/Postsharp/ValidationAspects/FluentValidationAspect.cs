using DevFramework.Core.CrossCuttingConcers.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Linq;
namespace DevFramework.Core.Aspects.Postsharp.ValidationAspect
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        private Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            if (_validatorType.BaseType == null) return;
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);
            var validator = Activator.CreateInstance(_validatorType);
            foreach (var entity in entities)
            {
                var validateMethod = typeof(ValidationTool)
                    .GetMethod("FluentValidate")
                    ?.MakeGenericMethod(entityType);
                if (validateMethod != null) validateMethod.Invoke(null, new[] { validator, entity });
            }
        }
    }
}
