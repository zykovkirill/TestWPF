using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Omega.Sales.Domain
{
    public class WinAuthentication : IAuthentication
    {
        public WinAuthentication()
        {
           
        }

        public bool IsAutentificate { get; private set; }

        public Task<IPrincipal> GetAutentification()
        {
           return Task.Run(() =>
            {
                //Thread.CurrentPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                //var UsName = Thread.CurrentPrincipal.Identity.Name;
                AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                //principal = Thread.CurrentPrincipal;
                return Thread.CurrentPrincipal;
                //var UsName = Thread.CurrentPrincipal.Identity.Name;
            });
        }
    }
}
