using System;
using System.Collections.Generic;

namespace HolisticWare.PharmaLogger.BusinessLogic
{
	public interface IBluetoothPrinterService
	{
		string Read();
		string ReadAsync();

		void Write(string data);
		void WriteAsync(string data);
	}
}

