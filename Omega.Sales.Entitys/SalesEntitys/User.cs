using Omega.Sales.Entitys.SalesEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omega.Sales.Entitys
{
    public class User : Record
    {
        public User()
        {
            Roles = new List<Role>();
        }
        #region Properties
        public string UserName { get; set; }
        public bool isBlock { get; set; }
        public bool? isSuperUser { get; set; }
        public string FullName { get; set; }
        public List<Role> Roles { get; set; }
        #endregion
    }
}
