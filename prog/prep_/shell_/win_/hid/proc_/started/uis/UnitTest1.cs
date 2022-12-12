using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._os_._TEST_.prog.prep_.shell_.win_.hid.proc_.started.uis
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var c = new nilnul.os.prog.prep_.shell_.win_.hid.proc_.Started(
			"notepad.exe"
			
			
		);
			var uis = os.prog.prep_.shell_.win_.hid.proc_.started._UiX.ThreadWinEs(
				c.process
			);



			var w = c.process.MainWindowHandle;

			Debug.WriteLine(w);

			var d=os.proc_.started.ui_._MainX.Attempted(c.process,1000);



			/// the window and the request to exit is not shown all time

			Debug.WriteLine(d);
		}
	}
}
