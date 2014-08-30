using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinForms.Demo.Pages.PCL
{
	class PageFactory
	{
		public static ContentPage ConentPage()
		{
			return new
					ContentPage
					{
						Content = new Label
						{
							Text = "Hello, Forms !",
							VerticalOptions = LayoutOptions.CenterAndExpand,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
						},
					};
		}



		public static MasterDetailPage MasterDetailPage()
		{
			return new
					MasterDetailPage
			{
				Master = new ContentPage 
							{ 
								Content = new Label() 
								{
									Text = "Detail"
								}
							}
			, Detail = new ContentPage 
							{ 
								Content = new Label() 
								{
									Text = "Detail"
								}
							}

			};
		}


	}
}
