﻿using System;
using System.Linq;


using HolisticWare.PharmaLogger.BusinessLogic;
using HolisticWare.PharmaLogger.BusinessLogic.XamariniOS;
using HolisticWare.PharmaLogger.Utilities;

[assembly:Xamarin.Forms.Dependency(typeof(BluetoothPrinterService))]

namespace HolisticWare.PharmaLogger.BusinessLogic.XamariniOS
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
