using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.address.op_.unary_;
using nilnul.fs.address;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace nilnul._os_._TEST_._this
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		static public string DataAddressOfCalling()
		{
			var assembly = Assembly.GetCallingAssembly();
			///bin\debug\asfa
			var appPath =_UpX._assumeUpNatural(nilnul.fs.address._UrlX.Unprefix(assembly.CodeBase), 3);;

			var division = @"_data(!Git\single\";

			var shield = nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(
				appPath, division
			);

			var link = nilnul.fs.folder.docs_.ext_._LnkX.Dnts(shield).Single();

			var linkAsAddress = new nilnul.fs.address_.spear_.based_.Child(
				shield
				,
				link
			);

			var tgt = nilnul.fs.file_.shortcut._VwX.Target(linkAsAddress);

			var path = tgt.ToString();// @"C:\Users\me\Desktop\Book1.xlsx";

			return path;

		}
	}
}
