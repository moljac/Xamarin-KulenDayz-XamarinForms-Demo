using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Demo.Controls
{
	class PageWithViewsInCode : Xamarin.Forms.ContentPage
	{
		public PageWithViewsInCode()
		{
			Content = BuildGrid();

			// Accomodate iPhone status bar.
			Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 10);
		}

		private Grid BuildGrid()
		{
			Grid grid =
					new Grid
					{
						VerticalOptions = LayoutOptions.FillAndExpand,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						RowDefinitions = 
							{
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
							},
						ColumnDefinitions = 
							{
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
							},
						Children =
							{
								{
									new Label 
									{
										Text = "Data:",
										HorizontalOptions = LayoutOptions.CenterAndExpand,
										VerticalOptions = LayoutOptions.FillAndExpand
									}
									, 0, 2, 0, 1
								},
								{
									new Label 
									{
										Text = "Data:",
										HorizontalOptions = LayoutOptions.CenterAndExpand,
										VerticalOptions = LayoutOptions.FillAndExpand
									}
									, 0, 2, 0, 1
								},
								{
									new Label 
									{
										Text = "Data:",
										HorizontalOptions = LayoutOptions.CenterAndExpand,
										VerticalOptions = LayoutOptions.FillAndExpand
									}
									, 0, 2, 0, 1
								},
								//{BuildPalletFrame(), 0, 1},
								//{new ContentView {
								//    Content = BuildDrawingFrame(),
								//    Padding = new Thickness(10, 0, 0, 0),
								//    HorizontalOptions = LayoutOptions.FillAndExpand,
								//    VerticalOptions = LayoutOptions.FillAndExpand
								//}, 1, 1}
							}
					};

			/*
			grid.Children.Add(new Label { Text = "This" }, 0, 0); // Left, First element
			grid.Children.Add(new Label { Text = "text is" }, 1, 0); // Right, First element
			grid.Children.Add(new Label { Text = "in a" }, 0, 1); // Left, Second element
			grid.Children.Add(new Label { Text = "grid!" }, 1, 1); // Right, Second element

			var gridButton = new Button { Text = "So is this Button! Click me." };
			gridButton.Clicked += delegate
			{
				gridButton.Text = string.Format("Thanks! {0} clicks.", count++);
			};
			grid.Children.Add(gridButton, 0, 2); // Left, Third element

			layout.Children.Add(grid);
			 */
			return grid;

		}

	}
}
