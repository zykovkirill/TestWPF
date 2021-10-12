using Microsoft.EntityFrameworkCore;
using Omega.Sales.Entitys;
using System.Linq;
using System.Windows.Controls;
using System;


namespace Omega.Sales.WPF.CustomControl
{
    /// <summary>
    /// ListView для Детали
    /// </summary>
    public partial class ListViewPart : ListView
    {
        public ListViewPart()
        {
            InitializeComponent();
            SetItemSource();
        }

        public async void SetItemSource()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TruckContext>();
            var options = optionsBuilder
                .UseSqlServer("Server=m-dts01;Database=ADTS_TEST2;Trusted_Connection=True;")
                .Options;
            using (var db = new TruckContext(options))
            ItemsSource = await db.tbx_N_Part.Take(100000).ToListAsync();
        }
    }
}
