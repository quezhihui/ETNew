using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ET.BUA.Service.Service;
using IdentityModel;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace ET.SSO.Server.Extension
{
    //public class ProfileService : IProfileService
    //{
    //    private IUserService _user;

    //    public ProfileService(IUserService user)
    //    {
    //        this._user = user;
    //    }

   //     public Task GetProfileDataAsync(ProfileDataRequestContext context)
   //     {
   //         try
   //         {
   //             var subjectId = context.Subject.GetSubjectId();
   //             var user = _user.(subjectId);

   //             var claims = new List<Claim>
   //         {
   //             new Claim(JwtClaimTypes.Id, user.ToString()),
			//	//add as many claims as you want!new Claim(JwtClaimTypes.Email, user.Email),new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean)
			//};

   //             context.IssuedClaims = claims;
   //             return Task.FromResult(0);
   //         }
   //         catch (Exception x)
   //         {
   //             return Task.FromResult(0);
   //         }
   //     }

   //     public Task IsActiveAsync(IsActiveContext context)
   //     {
   //         var user = _user.GetUserById(context.Subject.GetSubjectId());
   //         context.IsActive = (user != null) && user.Active;
   //         return Task.FromResult(0);
   //     }
    //}
}
