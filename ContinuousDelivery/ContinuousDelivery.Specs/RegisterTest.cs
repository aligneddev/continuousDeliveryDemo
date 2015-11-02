using System;
using Common.SeleniumTools;
using ContinuousDelivery.Web.UiMappings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContinuousDelivery.Specs
{
	[TestClass]
	public class RegisterTest : TestBase
	{
		[TestMethod]
		[TestCategory(TestCategories.Registration)]
		public void UserCanRegisterTest()
		{
			this.CurrentBrowserManager =  new BrowserManager();
			this.CurrentBrowserManager.Launch(BaseUri);
			var homePage = new HomePage();

			// we end up back on the home page
			string userName = "ben_" + DateTime.Now.Ticks + "@jump.com";
			homePage = homePage.RegisterUser(userName, "Pa$$word1");
			var helloMessage = homePage.GetAuthenticatedHeaderMessage();
			Assert.IsTrue(helloMessage.Contains(userName));
		}

		// TODO: delete the user
		// TODO: test login
		// TODO: create actually useful tests.
	}

	public class TestBase
	{
		public BrowserManager CurrentBrowserManager { get; set; }

		/// <summary>
		/// The uri of the site.
		/// This needs to be dynamic or changed before checking in for build tests to run.
		/// </summary>
		protected const string BaseUri = "http://localhost:2193/";

		[TestCleanup]
		public void TestCleanup()
		{
			CurrentBrowserManager.Quit();
		}
	}
}
