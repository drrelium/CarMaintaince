using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Diagnostics;

namespace CarMaintenance
{

    class CarTypeVM : BaseViewModel
    {
        public ObservableCollection<CarType> Cars { get; set; }
 //       public Command SaveCommand { get; set; }
   //     public Command CancelCommand { get; set; }
  //      CarType defaultCar;

        public CarTypeVM()
        {
            Cars = new ObservableCollection<CarType>();

            CarType testCar = new CarType
            {
                Year = "2003",
                Make = "Honda",
                Model = "CRV"
            };
            Cars.Add(testCar);

            MessagingCenter.Subscribe<NewCar, CarType>(this, "AddCar", (sender, arg) =>
            {
                Cars.Add(arg);
            });

/*
            SaveCommand = new Command(
                execute: () =>
                {
                    Debug.WriteLine("Adding car.");

                    Cars.Add(defaultCar);

                },
                canExecute: () =>
                {
                    Debug.WriteLine("Checking car input");

                    return defaultCar != null &&
                            defaultCar.Year < 1000 &&
                            defaultCar.Year >= currentYear &&
                            defaultCar.Make != null &&
                            defaultCar.Model != null;
                }
            ); */
        }
    }
}
