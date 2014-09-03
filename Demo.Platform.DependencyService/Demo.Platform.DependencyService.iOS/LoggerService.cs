using System;

using Demo.Platform.DependencyService.XamariniOS;


[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace Demo.Platform.DependencyService.XamariniOS
{
	public class LoggerService
	{
		public LoggerService ()
		{
		}

		public static void WriteLine (string log)
		{
			System.Diagnostics.Trace.WriteLine(log);


			//XUbertestersSDK.XUbertesters.LogInfo(log);

			return;
		}
	}
}

