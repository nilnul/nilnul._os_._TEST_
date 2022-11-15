using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._os_._TEST_.app.data.address
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				System.IO.Path.GetFullPath("%AppData%")
			); // literally a dnt

			Debug.WriteLine(
				Environment.GetEnvironmentVariable("%AppData%")
			); //no value
			Debug.WriteLine(
				Environment.GetEnvironmentVariable("AppData")
			); //C:\Users\u\AppData\Roaming

			Debug.WriteLine(
				Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData)
			); //C:\Users\u\AppData\Roaming

			Debug.WriteLine("local: "+
				Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData)
			); //C:\Users\u\AppData\Local

			Debug.WriteLine(
				"common: "+
				Environment.GetFolderPath( Environment.SpecialFolder.CommonApplicationData)
			); //C:\ProgramData



		}
	}
}
