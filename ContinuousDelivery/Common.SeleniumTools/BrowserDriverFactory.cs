using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;

namespace Common.SeleniumTools
{
	public static class BrowserDriverFactory
	{
		public static RemoteWebDriver CreateDriver(BrowserType browserType)
		{
			switch (browserType)
			{
				case BrowserType.Ie:
					return new InternetExplorerDriver();
				case BrowserType.Edge:
					return new EdgeDriver();
				case BrowserType.Firefox:
					return new FirefoxDriver();
				case BrowserType.Chrome:
					return new ChromeDriver();
				case BrowserType.PhantomJs:
					return new PhantomJSDriver();
				default:
					throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
			}
		}
	}
}