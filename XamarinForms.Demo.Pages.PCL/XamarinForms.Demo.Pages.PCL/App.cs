using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinForms.Demo.Pages.PCL
{
	public class App
	{
		public static Page GetMainPage()
		{
			return 
				//PageFactory.ConentPage()
				//PageFactory.NavigationPage()
				//PageFactory.TabbedPage()
				//PageFactory.CarouselPage()
				PageFactory.MasterDetailPage()
					;
		}
	}
}
