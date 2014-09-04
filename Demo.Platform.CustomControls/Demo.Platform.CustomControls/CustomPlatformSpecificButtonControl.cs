using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.Platform.CustomControls
{
	class CustomPlatformSpecificButtonControl : Button
	{
		public static readonly BindableProperty SourceProperty =
			BindableProperty.Create<CustomPlatformSpecificButtonControl, ImageSource>
			(
				p => p.Source, null
			);

		[TypeConverter(typeof(ImageSourceConverter))]
		public ImageSource Source
		{
			get { return (ImageSource)GetValue(SourceProperty); }
			set { SetValue(SourceProperty, value); }
		}

	}



	public class ImageSourceConverter : TypeConverter
	{
		public override bool CanConvertFrom(Type sourceType)
		{
			return sourceType == typeof(string);
		}

		public override object ConvertFrom(CultureInfo culture, object value)
		{
			if (value == null)
			{
				return null;
			}

			var str = value as string;
			if (str != null)
			{
				Uri result;
				if (!Uri.TryCreate(str, UriKind.Absolute, out result) || !(result.Scheme != "file"))
				{
					return ImageSource.FromFile(str);
				}
				return ImageSource.FromUri(result);
			}
			throw new InvalidOperationException(
				string.Format("Conversion failed: \"{0}\" into {1}",
					new[] { value, typeof(ImageSource) }));
		}
	}
}
