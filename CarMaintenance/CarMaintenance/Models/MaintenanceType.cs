using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CarMaintenance
{
	public class MaintenanceType 
	{
            public string DisplayName { get; set; }
            public DateTime LastServiced { get; set; }
            public string NextServiceTime { get; set; }
            public string NextServiceMilage { get; set; }
	}
}