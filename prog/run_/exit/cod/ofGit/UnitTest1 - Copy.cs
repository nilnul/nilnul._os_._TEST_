using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._os_._TEST_.prog.run_.exit.cod.ofGit
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var c=nilnul.os.prog.run_.exit._CodX._ExitCode(
				nilnul.os.prog_.git.nulable.Fallback.NotNul().val.location
				,
				"fsck --full"
				,
				@"C:\Users\wangy\src_\my\wyt.parenting._yiyi_\220520(Git"
				,
				5 *1000
				
			);
			Debug.WriteLine(c);
		}
	}
}
