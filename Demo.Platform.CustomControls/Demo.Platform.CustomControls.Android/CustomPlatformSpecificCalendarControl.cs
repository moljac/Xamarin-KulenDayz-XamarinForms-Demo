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
using Xamarin.Forms;


using Demo.Platform.CustomControls.Droid;


[assembly: 
	Xamarin.Forms.ExportRenderer 
		(
		  typeof (Demo.Platform.CustomControls.CustomPlatformSpecificCalendarControl)
		, typeof (Demo.Platform.CustomControls.XamarinAndroid.CustomPlatformSpecificCalendarControlRenderer)
		)
]

namespace Demo.Platform.CustomControls.XamarinAndroid
{
	public partial class CustomPlatformSpecificCalendarControlRenderer 
		: 
		Xamarin.Forms.Platform.Android.NativeRenderer
	{

		private const string TAG = "Xamarin.Forms.Calendar";
 
		CalendarView _view;
		CalendarPickerView _pickerView;

		public CustomPlatformSpecificCalendarControlRenderer()
		{
		}
 
		protected override void OnModelChanged (VisualElement oldModel, VisualElement newModel)
		{
			_view = (CustomPlatformSpecificCalendarControl)newModel;
 
			base.OnModelChanged (oldModel, newModel);
 
			LayoutInflater inflatorservice = 
							  (LayoutInflater) Context.GetSystemService(Android.Content.Context.LayoutInflaterService);
			var containerView = 
								(LinearLayout)inflatorservice.Inflate (Resource.Layout.calendar_picker, null, false);
 
			_pickerView = containerView.FindViewById<CalendarPickerView>(Resource.Id.calendar_view);
			_pickerView.Init (new DateTime (2014, 6, 1), new DateTime (2014, 6, 30))
				.InMode (CalendarPickerView.SelectionMode.Single);
 
			_pickerView.OnDateSelected += (s, e) => {
				_view.NotifyDateSelected(e.SelectedDate);
			};
 
			SetNativeControl (containerView);
		}
	}
}