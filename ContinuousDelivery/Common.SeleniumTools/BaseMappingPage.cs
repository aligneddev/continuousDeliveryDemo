using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Common.SeleniumTools
{
	/// <summary>
	/// A possible internal NuGet package for base functionality layered on Selenium.
	/// </summary>
	public class BaseMappingPage
	{
		protected RemoteWebDriver Driver => BrowserManager.Driver;
	}
}