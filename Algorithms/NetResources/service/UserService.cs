using FluentValidation.Results;
using NetResources.FluentValidation;
using NetResources.Model;

namespace NetResources.service
{
    internal class UserService
    {
        IEnumerable<User> _users;

        public UserService()
        {
            _users = new List<User>();
        }

        internal ValidationResult AddUser(User user)
        {
            UserValidator userValidator = new UserValidator();
            GuidValidator guidValidator = new GuidValidator();
            ValidationResult result = userValidator.Validate(user);
            ValidationResult guidResult = guidValidator.Validate(user.rowGuid);
            if (result.IsValid && guidResult.IsValid)
            {
                _users = _users.Append(user);
            }

            return result;
        }

        internal IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}
