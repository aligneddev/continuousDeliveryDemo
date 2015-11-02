using System;
using System.Net.NetworkInformation;
using OpenQA.Selenium.Remote;

namespace Common.SeleniumTools
{
	/// <summary>
	/// Manage the browser instances for Selenium tests.
	/// </summary>
	public class BrowserManager
	{
		public static RemoteWebDriver Driver { get; private set; }

		/// <summary>
		/// Launch must be called in order to populate the browser and open it.
		/// </summary>
		/// <param name="baseUri"></param>
		/// <param name="browserType"></param>
		public void Launch(string baseUri, BrowserType browserType = BrowserType.Firefox)
		{
			Driver = BrowserDriverFactory.CreateDriver(browserType);
			Driver.Navigate().GoToUrl(baseUri);
		}

		public void Quit()
		{
			Driver.Quit();
		}
	}
}
