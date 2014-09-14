using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Demo.Controls
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			this.buttonConotrolsInCode.Clicked += buttonConotrolsInCode_Clicked;

			return;
		}

		private void buttonConotrolsInCode_Clicked (object sender, EventArgs e)
		{
			return;			
		}

		private void buttonConotrolsInXaml_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageWithViewsInXaml());


			return;			
		}
	}
}
