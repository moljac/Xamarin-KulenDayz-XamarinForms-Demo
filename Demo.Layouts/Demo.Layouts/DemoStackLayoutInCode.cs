using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Demo.Layouts
{
	/// <summary>
	/// StackLayout
	///		A Layout that positions child elements in a single line which 
	///		can be oriented vertically or horizontally. 
	///		
	///		This layout will set the child bounds automatically during a layout cycle.
	///		User assigned bounds will be overwritten and thus should not be set on a 
	///		child element by the user.
	/// </summary>
	public class DemoStackLayoutInCode : ContentPage
	{
		public DemoStackLayoutInCode()
		{
			StackLayout stack_layout =  new StackLayout();

			//if (Device.OS == TargetPlatform.iOS) 
			{
			    // move layout under the status bar
				//stack_layout.Padding = new Thickness (0, 20, 0, 0);
			}




			StackLayout stack_layout_h =  new StackLayout()
			{
				Orientation = StackOrientation.Horizontal
			};

			stack_layout_h.Children.Add( new Label() { Text = "Data:" });

			stack_layout_h.Children.Add( new Entry(){ Placeholder = "data" });

			stack_layout_h.Children.Add( new Button(){ Text = "Send" } );

			StackLayout stack_layout_o =  new StackLayout()
			{
				Orientation = StackOrientation.Vertical
			};

			stack_layout_o.Children.Add
				(
					new Label() 
					{
						Text = "Data:"
					}
				);

			stack_layout_o.Children.Add
				(
					new Entry()
					{
						Placeholder = "data"
					}
				);

			stack_layout_o.Children.Add
				(
					new Button()
					{
						Text = "Send"
					}
				);

			stack_layout.Children.Add(stack_layout_h);
			stack_layout.Children.Add(stack_layout_o);

			this.Content = stack_layout;

			return;
		}

	}
}
