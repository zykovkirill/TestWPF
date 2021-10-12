using Omega.Sales.Entitys.SalesEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omega.Sales.Entitys
{
    public class Role : Record
    {
        public Role()
        {
            Users = new List<User>();
        }
        #region Properties
        public string RoleName { get; set; }
        public string? ParentRole { get; set; }
        public bool? isBlock{ get; set; }
        public List<User> Users { get; set; }
        #endregion
    }
}
