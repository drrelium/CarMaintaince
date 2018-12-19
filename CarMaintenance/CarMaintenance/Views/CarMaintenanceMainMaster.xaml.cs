using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMaintenance
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarMaintenanceMainMaster : ContentPage
    {
        public ListView ListView;

        public CarMaintenanceMainMaster()
        {
            InitializeComponent();

            BindingContext = new CarMaintenanceMainMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CarMaintenanceMainMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CarMaintenanceMainMenuItem> MenuItems { get; set; }
            
            public CarMaintenanceMainMasterViewModel()
            {
                MenuItems = new ObservableCollection<CarMaintenanceMainMenuItem>(new[]
                {
                    new CarMaintenanceMainMenuItem { Id = 0, Title = "Change Car", TargetType = typeof(CarTypeView) },
                    new CarMaintenanceMainMenuItem { Id = 1, Title = "Maintenance History", TargetType = typeof(CarHistory) },
                    new CarMaintenanceMainMenuItem { Id = 2, Title = "Gas History" },
                    new CarMaintenanceMainMenuItem { Id = 3, Title = "Export to Excel" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}