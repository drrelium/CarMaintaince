using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMaintenance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarTypeView : ContentPage
	{
        CarTypeVM carTypeModel;
   //     public CarType Cars { get; set; }

        public CarTypeView()
        {
            InitializeComponent();
            BindingContext = carTypeModel = new CarTypeVM();
        }

        public void AddItem_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine("Add button clicked");
            Navigation.PushAsync(new NewCar());
        }
    }
}