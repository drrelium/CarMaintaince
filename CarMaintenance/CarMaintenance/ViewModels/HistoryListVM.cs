using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarMaintenance
{
	public class HistoryListVM : BaseViewModel
	{

        public ObservableCollection<MaintenanceType> MaintenanceList { get; set; }

        public HistoryListVM ()
		{
            MaintenanceList = new ObservableCollection<MaintenanceType>();

            MaintenanceList.Add(new MaintenanceType
            {
                DisplayName = "Oil Change",
            });
            MaintenanceList.Add(new MaintenanceType
            {
                DisplayName = "Oil Filter",
            });
            MaintenanceList.Add(new MaintenanceType
            {
                DisplayName = "Engine Filter",
            });
        }
	}
}