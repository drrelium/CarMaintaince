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
	public partial class NewCar : ContentPage
	{

        CarType defaultCar;
  //      List<String> carYearList;

        public NewCar ()
		{
			InitializeComponent ();
            defaultCar = new CarType();

            MakeYearSelector();

            BindingContext = this;
        }

        public void MakeYearSelector()
        {
            var carYearList = new List<String>();
            int currentYear = DateTime.Now.Year;
            for (int x = currentYear + 1; x > currentYear - 29; x--)
            {
                carYearList.Add(x.ToString());
            }
            YearPicker.ItemsSource = carYearList;
        }

        public void Cancel_Clicked(object sender, EventArgs args)
        {
            Navigation.PopAsync();
        }

        public void Save_Clicked(object sender, EventArgs args)
        {
            defaultCar.Year = (string) YearPicker.SelectedItem;
            defaultCar.Make = EntryMake.Text;
            defaultCar.Model = EntryModel.Text;


            MessagingCenter.Send(this, "AddCar", defaultCar);
            Debug.WriteLine("Default car is: " + defaultCar.Year + " " + defaultCar.Make + " " + defaultCar.Model);
            Navigation.PopAsync();

        }
    }
}