using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMaintenance
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewCar : ContentPage
	{
        CarType NewCarType;

		public NewCar ()
		{
			InitializeComponent ();
            YearEditor.Completed += YearEditorCompleted;

            NewCarType = new CarType();

        }

        public void Cancel_Clicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();

        }

        public void Save_Clicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

        void YearEditorCompleted(object sender, EventArgs e)
        {
            NewCarType.Year = ((Editor)sender).Text; 
        }

        void MakeEditorCompleted(object sender, EventArgs e)
        {
            NewCarType.Make = ((Editor)sender).Text;
        }

        void ModelEditorCompleted(object sender, EventArgs e)
        {
            NewCarType.Model = ((Editor)sender).Text; 
        }
    }
}