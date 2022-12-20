using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.delay.status_.complete.onComplete
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
				5 * 1000
				,
				c.Token
			);


			var d= t	.ContinueWith(
				t000 => {
					run = true;

				}
				,TaskContinuationOptions.OnlyOnRanToCompletion
				
			);

			//c.Cancel();

			Thread.Sleep( 10*1000);


			if (run==false)
			{
				throw new Exception(
					@"
							task canceled is regarded as completion.
					"
				);
			}

		}
	}
}
