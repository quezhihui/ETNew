using ET.BUA.Service.Service;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using System.Threading.Tasks;

namespace ET.SSO.Server.Extension
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        IUserService _user;

        public ResourceOwnerPasswordValidator(IUserService user)
        {
            this._user = user;
        }

        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            if (_user.ValidateCredentials(context.UserName, context.Password))
            {
                context.Result = new GrantValidationResult(_user.FindByUserUID(context.UserName).USER_UID, "password", null, "local", null);
                return Task.FromResult(context.Result);
            }
            context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "The username and password do not match", null);
            return Task.FromResult(context.Result);
        }
    }
}
