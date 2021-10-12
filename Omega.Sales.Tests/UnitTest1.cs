using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.DirectoryServices;
using System.Security.Principal;
using System.Threading;

namespace Omega.Sales.Tests
{
    [TestClass]
    public class DomainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.CurrentPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
             var UsName=Thread.CurrentPrincipal.Identity.Name;
            


            DirectoryEntry CurrendDomain = new DirectoryEntry("LDAP://OU=Omega,DC=etsp,DC=ru");

            Array roles = Enum.GetValues(typeof(WindowsBuiltInRole));

            using (var searcher = new DirectorySearcher(CurrendDomain)) {

                searcher.Filter = string.Format("(sAMAccountName={0})", UsName);
                var result = searcher.FindOne();
            }

                var sss = CurrendDomain.Children;

            
        }
    }
}
