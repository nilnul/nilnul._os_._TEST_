using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul._os_._TEST_.nilnul0.app.task_.faulted.onCancel
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t = Task.FromException(
				new Exception()
			);
			var b = false;

			var d = t.ContinueWith(
				x => {
					b = true;
				}
				,
				TaskContinuationOptions.OnlyOnCanceled
			);

			if (b)
			{
				throw new Exception();
			}

		}
	}
}
