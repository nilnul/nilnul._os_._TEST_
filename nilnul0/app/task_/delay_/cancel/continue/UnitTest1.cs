using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.delay.status.continued
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
				10 * 1000
				,
				c.Token
			);


			var d= t.ContinueWith(
				t000 => {
					run = true;

				}
				,TaskContinuationOptions.NotOnCanceled
				
			);

			c.Cancel();

			Thread.Sleep( 3*1000);

			try
			{
				d.Wait();

			}
			catch (AggregateException a)
			{
				a.Handle(
					x=> x is TaskCanceledException tt && tt.Task==d && d.IsCanceled ?true:false
				);
			}


			

		}
	}
}
