using Microsoft.EntityFrameworkCore;
using Omega.Sales.Entitys;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Omega.Sales.WPF.CustomControl
{
    /// <summary>
    /// Логика взаимодействия для AdminControl.xaml
    /// </summary>
    public partial class RolesControl : UserControl
    {

        private ObservableCollection<RoleView> _RoleList = new ObservableCollection<RoleView>();

        public ObservableCollection<RoleView> RoleList
        {
            get { return _RoleList; }
            set
            {
                _RoleList = value;
            }
        }

        public RolesControl()
        {
            InitializeComponent();
            SetItemSource();
        }
        public async void SetItemSource()
        {

            var db = new SalesContext();
            var roles = await db.Roles.ToListAsync();
            var roleViewCollection = new ObservableCollection<RoleView>();
            var childrenRoleViewList = new List<RoleView>();

            foreach (var role in roles)
            {

                var rv = new RoleView()
                {
                    Id = role.Id,
                    RoleName = role.RoleName,
                    ParentRole = role.ParentRole
                };

                roleViewCollection.Add(rv);
            }

            foreach (var role in roleViewCollection)
            {
                var prvl = roleViewCollection.Where(r => r.ParentRole == role.Id);
                childrenRoleViewList.AddRange(prvl);
                role.ChildrenRoleList = new ObservableCollection<RoleView>(prvl);
                RoleList.Add(role);
            }

            foreach (var child in childrenRoleViewList)
                RoleList.Remove(child);

            var test1 = new Test1();
            test1.RoleList = RoleList;
            DataContext = test1;

        }
    }

    public class RoleView : Role
    {
        private ObservableCollection<RoleView> _ChildrenRoleListList = new ObservableCollection<RoleView>();

        public ObservableCollection<RoleView> ChildrenRoleList
        {
            get { return _ChildrenRoleListList; }
            set
            {
                _ChildrenRoleListList = value;
            }
        }
    }

    public class Test1
    {
        public ObservableCollection<RoleView> RoleList { get; set; }

    }

}


