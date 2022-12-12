using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.faulted.wait
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var e = new Exception();
			var t = Task.FromException(
				e
			);

			try
			{
			t.Wait();

			}
			catch (AggregateException a)
			{

				a.Handle(
					x=> x==e?true:false
				);
			}


		

		}
	}
}
