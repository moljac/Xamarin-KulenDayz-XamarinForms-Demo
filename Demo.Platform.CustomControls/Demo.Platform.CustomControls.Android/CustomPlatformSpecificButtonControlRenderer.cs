using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Demo.Platform.CustomControls.Droid
{
	class CustomPlatformSpecificButtonControlRenderer
	{
		private static Xamarin.Forms.Platform.Android.IImageSourceHandler 
				GetHandler(Xamarin.Forms.ImageSource source)
		{
			Xamarin.Forms.Platform.Android.IImageSourceHandler returnValue = null;
			if (source is Xamarin.Forms.UriImageSource)
			{
				returnValue = new Xamarin.Forms.Platform.Android.ImageLoaderSourceHandler();
			}
			else if (source is Xamarin.Forms.FileImageSource)
			{
				returnValue = new Xamarin.Forms.Platform.Android.FileImageSourceHandler();
			}
			else if (source is Xamarin.Forms.StreamImageSource)
			{
				returnValue = new Xamarin.Forms.Platform.Android.StreamImagesourceHandler();
			}
			return returnValue;
		}
	}
}