using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Omega.Sales;
using Omega.Sales.Entitys;

namespace Omega.Sales.WPF.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private tbx_N_Part selectedPart;

        public ObservableCollection<tbx_N_Part> Parts { get; set; }
        public tbx_N_Part SelectedPart
        {
            get { return selectedPart; }
            set
            {
                selectedPart = value;
                OnPropertyChanged("SelectedPart");
            }
        }

        public ApplicationViewModel()
        {
            //  SetDataSourceAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //public async void SetDataSourceAsync()
        //{
        //    var data = await Task.Run(() => APIRequest.GetObjectAsync<tbx_N_Part>(URL.urlParts));
        //    Parts = new ObservableCollection<tbx_N_Part>(data);
        //}
    }
}
