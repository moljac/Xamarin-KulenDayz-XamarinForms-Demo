using System;

using Demo.Platform.DependencyService.WindowsPhone;

[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace Demo.Platform.DependencyService.WindowsPhone
{
	public class LoggerService
	{
		public LoggerService ()
		{
		}

		public static void WriteLine (string log)
		{
			// no Trace in Windows Phone
			//System.Diagnostics.Trace.WriteLine(log);

			// no Trace in Windows Phone
			System.Diagnostics.Debug.WriteLine(log);


			//XUbertestersSDK.XUbertesters.LogInfo(log);

			return;
		}
	}
}

