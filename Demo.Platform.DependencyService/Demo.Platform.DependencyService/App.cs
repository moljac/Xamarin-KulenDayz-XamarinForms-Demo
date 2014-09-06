using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo.Platform.DependencyService
{
	public class App
	{
		public static Page GetMainPage()
		{
			return UIPageWithCode();
			//return UIPageWithXaml();			
		}

		public static ContentPage UIPageWithCode()
		{
			Label labelText = new Label()
			{
				Text = "Data:"
			};

			Entry entryData = new Entry()
			{
				Placeholder = "data"
			};

			Button buttonPrint = new Button()
			{
				Text = "Print"
			};

			buttonPrint.Clicked += buttonPrint_Clicked;


			StackLayout sl = new StackLayout()
			{
				Orientation  = StackOrientation.Vertical
			};

			sl.Children.Add(labelText);
			sl.Children.Add(entryData);
			sl.Children.Add(buttonPrint);





			ContentPage page = new ContentPage()
			{
				Content = sl
			};

			return page;
		}

		static void buttonPrint_Clicked(object sender, EventArgs e)
		{

			// KUD Idijote:
			//		upali BT
			//		alo permissions
			IBluetoothPrinterService ibs = null;

			// get Registered service from Platform lib
			ibs = Xamarin.Forms.DependencyService.Get<IBluetoothPrinterService>();

			string data = "KulenDayz 2014";

			ibs.Write(data);


			return;
		}
	}
}
