using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.Platform.CustomControls
{
	public partial class CustomPlatformSpecificCalendarControl : Xamarin.Forms.View
	{
		public CustomPlatformSpecificCalendarControl()
		{
		}

		public void NotifyDateSelected(DateTime dateSelected)
		{
			if (DateSelected != null)
				DateSelected(this, dateSelected);
		}

		public event EventHandler<DateTime> DateSelected;
	}
}
