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
			Button buttonPrint = new Button()
			{
				Text = "Print"
			};

			buttonPrint.Clicked += buttonPrint_Clicked;
			ContentPage page = new ContentPage()
			{
				Content = buttonPrint
			};

			return page;
		}

		static void buttonPrint_Clicked(object sender, EventArgs e)
		{
			IBluetoothPrinterService ibs = null;
			

			// get Registered service from Platform lib
			ibs = Xamarin.Forms.DependencyService.Get<IBluetoothPrinterService>();

			string data = "KulenDayz 2014";

			ibs.Write(data);

			return;
		}
	}
}
