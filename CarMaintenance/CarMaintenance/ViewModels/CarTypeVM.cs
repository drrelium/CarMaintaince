using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace CarMaintenance
{

    class CarTypeVM : BaseViewModel
    {
        public ObservableCollection<CarType> Cars { get; set; }
        public CarType CurrentCar;

        public CarTypeVM()
        {
            Cars = new ObservableCollection<CarType>();

            CarType defaultCar = new CarType();
            defaultCar.Make = "Please add a car";
            Cars.Add(defaultCar);
            CurrentCar = defaultCar;
        }

        public string CarLabel(CarType car)
        {
            return string.Format("{0} {1} {2}", car.Year, car.Make, car.Model);
        }

    }
}
