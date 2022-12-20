using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.delay_.cancel.onDefaulted
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var run = false;

			var c = new CancellationTokenSource();
			var t = Task.Delay(
				15 * 1000
				,
				c.Token
			);

			Thread.Sleep(1000);

			c.Cancel();

			var d= t.ContinueWith(
				t111=> {
					

				}
			);

			Thread.Sleep(1000);

			d.Wait();


			

		}
	}
}
