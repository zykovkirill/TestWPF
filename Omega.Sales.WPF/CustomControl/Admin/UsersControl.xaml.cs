using Microsoft.EntityFrameworkCore;
using Omega.Sales.Entitys;
using System;
using System.Collections.Generic;
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
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            SetItemSource();
        }
        public async void SetItemSource()
        {
            var db = new SalesContext();

            var users = await db.Users.Include(u => u.Roles).ToListAsync();
            var roles = await db.Roles.ToListAsync();

            var userRole= new UserRole();
            userRole.Users = users;
            userRole.Role = roles;
            DataContext = userRole;
        }
    }

    public class UserRole
    {
        public List<User> Users { get; set; }
        public List<Role> Role { get; set; }
    }
}

