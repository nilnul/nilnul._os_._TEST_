using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task.coninuation_.onCancelled
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var cts = new CancellationTokenSource();

			var expected = false;

			var t1 = System.Threading.Tasks.Task.Delay(
			   10 * 1000
			   ,
			   cts.Token
		   ).ContinueWith(
			   (t) =>
			   {
				   expected = true;
			   }
			   ,
			   cts.Token
			   ,
			   TaskContinuationOptions.OnlyOnCanceled
			   , TaskScheduler.Current
			);
			cts.Cancel();
			t1.Wait();
			Assert.IsTrue(expected);
		}

	}
}
