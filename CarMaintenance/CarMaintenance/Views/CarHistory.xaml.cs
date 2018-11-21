using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMaintenance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarHistory : ContentPage
	{
        HistoryListVM historyList;
    

        public CarHistory ()
		{
            InitializeComponent();
            historyList = new HistoryListVM();
            BindingContext = historyList;
        }

    }
}