﻿using System;
using System.Linq;


using Demo.Platform.DependencyService.XamariniOS;


[assembly:Xamarin.Forms.Dependency(typeof(BluetoothPrinterService))]

namespace Demo.Platform.DependencyService.XamariniOS
{
	public partial class BluetoothPrinterService : IBluetoothPrinterService
	{ 
		public BluetoothPrinterService ()
		{
			return;	
		}

		public string Read ()
		{
			return "";
		}

		public string ReadAsync ()
		{
			// Read data from the device
			//await 

			return "";
		}

		public void Write (string data)
		{
			LoggerService.WriteLine ("Android Bluetooth write fired = ");


			return;
		}

		public void WriteAsync (string data)
		{
			LoggerService.WriteLine ("Android Bluetooth write fired = ");

			return;
		}
	}
}

