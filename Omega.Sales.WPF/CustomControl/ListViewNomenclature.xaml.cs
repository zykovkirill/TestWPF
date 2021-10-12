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
using System.Windows.Shapes;


namespace Omega.Sales.WPF.CustomControl
{
    /// <summary>
    /// ListView для Номенкулатуры 
    /// </summary>
    public partial class ListViewNomenclature : ListView
    {
        public ListViewNomenclature()
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
            //TODO: Take(100000) - указывать в парамметрах конкретное кол-во
            using (var db = new TruckContext(options))
                ItemsSource = await db.tbc_N_Part_Nomenclature_Specifications.Take(100000).ToListAsync();
        }
    }
}
