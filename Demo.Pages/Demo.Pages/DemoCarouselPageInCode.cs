﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Demo.Pages
{
	class DemoCarouselPageInCode : CarouselPage
	{
		public DemoCarouselPageInCode ()
		{
			this.Title = "CarouselPage";

			this.Children.Add
				(
					new ContentPage
						{
							Title = "Blue",
							Content = new BoxView
							{
								Color = Color.Blue,
								HeightRequest = 100f,
								VerticalOptions = LayoutOptions.Center
							},
						}
				);

			this.Children.Add
				(
					new ContentPage
						{
							Title = "Blue and Red",
							Content = new StackLayout
							{
								Children = 
								{
								new BoxView { Color = Color.Blue },
								new BoxView { Color = Color.Red}
								}
							}
						}
				);

			return;
		}
	}
}
