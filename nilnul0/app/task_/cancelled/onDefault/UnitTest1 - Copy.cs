using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.cancelled.onDefault
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var cts = new CancellationTokenSource();
			cts.Cancel();
			var t = Task.FromCanceled(
				cts.Token
			);

			var b = false;

			var d = t.ContinueWith(
				x => {
					b = true;
				}
			);

			d.Wait();

			if (!b)
			{
				throw new Exception();
			}

		}
	}
}
