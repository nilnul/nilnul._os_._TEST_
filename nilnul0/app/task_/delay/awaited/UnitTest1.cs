using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.delay.awaited
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public  void TestMethod1()
		{
			var tt = t();

			try
			{
				tt.Wait();

			}
			catch (AggregateException ex)
			{
				ex.Handle(
					e=>
					e is TaskCanceledException  xxx && xxx.Task==tt  ?true:false
				);

				//ex.Flatten().Handle(
				//	e=>
				//	e is TaskCanceledException  xxx && xxx.Task==tt  ?true:false
				//);
			}
			

			

		}
		public async Task t()
		{

			var c = new CancellationTokenSource();
	

			c.Cancel();

			await Task.Delay(
				10*1000
				,
				c.Token
			);
			// an exception: taskCancelledException;

			var b = 3;
			

		}


	}
}
