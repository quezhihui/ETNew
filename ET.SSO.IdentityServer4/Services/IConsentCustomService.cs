using IdentityServer4.Quickstart.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ET.SSO.IdentityServer4.Services
{
    public interface IConsentCustomService
    {
        Task<ConsentViewModel> BuildViewModelAsync(string returnUrl, ConsentInputModel model = null);

        Task<ProcessConsentResult> ProcessConsent(ConsentInputModel model);
    }
}
