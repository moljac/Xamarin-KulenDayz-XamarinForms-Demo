using System;
using System.Collections.Generic;

namespace Demo.Platform.DependencyService
{
	public interface IBluetoothPrinterService
	{
		string Read();
		string ReadAsync();

		void Write(string data);
		void WriteAsync(string data);
	}
}

