using FluentValidation;

namespace NetResources.FluentValidation
{
    internal class GuidValidator: AbstractValidator<Guid>
    {
        public GuidValidator() { 
            RuleFor(x => x).NotEmpty().WithMessage("Code is required");
        }
    }
}
