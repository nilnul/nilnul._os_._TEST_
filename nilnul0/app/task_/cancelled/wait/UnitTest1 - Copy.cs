using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.cancelled.wait
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
			try
			{
			t.Wait();

			}
			catch (AggregateException a)
			{
				a.Handle(
					t0 =>t0 is TaskCanceledException x && x.CancellationToken==cts.Token ? true:false
				);

				//		throw;
			}


		

		}
	}
}
