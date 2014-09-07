using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo.Pages
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new 
						//DemoCarouselPageInCode()
						DemoCarouselPageInXaml()

						//DemoTabbedPageInCode()
						//DemoTabbedPageInXaml()
						//
						;
		}
	}
}
