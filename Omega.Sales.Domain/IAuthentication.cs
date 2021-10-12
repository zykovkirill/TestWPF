using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Omega.Sales.Domain
{
    public interface IAuthentication
    {
       bool IsAutentificate{ get; }

       Task<IPrincipal> GetAutentification();

       delegate void OnAutentificated();
    }
}
