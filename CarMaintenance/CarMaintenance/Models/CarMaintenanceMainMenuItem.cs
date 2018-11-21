using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMaintenance
{

    public class CarMaintenanceMainMenuItem
    {
        public CarMaintenanceMainMenuItem()
        {
            TargetType = typeof(CarMaintenanceMainDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}