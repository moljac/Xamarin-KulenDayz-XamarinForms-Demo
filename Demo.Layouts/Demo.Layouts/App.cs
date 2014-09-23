using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Demo.Layouts
{
	public class App
	{
		public static Page GetMainPage()
		{
			Page page = new 
							// DemoContentView()

							// DemoFrame()

							// DemoScrollView()

							//DemoStackLayout()
							// DemoStackLayoutInCode()

							// DemoAbsoluyeLayout()

							// DemoRelativeLayout()

							DemoGridLayout()
							;
			return page;
		}
	}
}
