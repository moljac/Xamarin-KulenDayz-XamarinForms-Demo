using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo.Platform.CustomControls
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

			ContentPage page = new ContentPage()
			{
				Content = buttonPrint
			};

			return page;
		}
	}
}
