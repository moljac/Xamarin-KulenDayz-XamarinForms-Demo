using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Demo.Pages
{
	class DemoMasterDetailPageInCode : MasterDetailPage
	{
		public DemoMasterDetailPageInCode()
		{
			Label header = new Label
			{
				Text = "MasterDetailPage",
				Font = Font.BoldSystemFontOfSize(30),
				HorizontalOptions = LayoutOptions.Center
			};

			// Assemble an array of NamedColor objects.
			string[] namedColors = 
				{
					"1",
					"2",
					"3",
					"4",
					"5",
					"6",
					"7",
				};

			// Create ListView for the master page.
			ListView listView = new ListView
			{
				ItemsSource = namedColors
			};

			// Create the master page with the ListView.
			this.Master = new ContentPage
			{
				Content = new StackLayout
				{
					Children = 
					{
						header, 
						listView
					}
				}
			};

			// Create the detail page using NamedColorPage
			this.Detail = new ContentPage()
				{
						Title = "Details"
				};

			// For Windows Phone, provide a way to get back to the master page.
			if (Device.OS == TargetPlatform.WinPhone)
			{
				(this.Detail as ContentPage).Content.GestureRecognizers.Add(
					new TapGestureRecognizer((view) =>
					{
						this.IsPresented = true;
					}));
			}

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = namedColors[0];


		}
	}
}
