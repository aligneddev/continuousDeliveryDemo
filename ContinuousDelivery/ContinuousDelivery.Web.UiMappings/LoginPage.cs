using Common.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ContinuousDelivery.Web.UiMappings
{
	/// <summary>
	/// Map the UI for the login page.
	/// </summary>
	internal class LoginPage : BaseMappingPage
	{
		public void Login(string username, string password)
		{
			this.SetUsername(username);
			this.SetPassword(password);
			this.GetLoginButton().Click();
		}

		private IWebElement GetLoginButton()
		{
			// convention to put auto- for ids/classes that are added for automation mapping
			// I added the id to the Login.cshtml page
			return this.Driver.FindElement(By.Id("auto-LoginButton"));
		}

		private void SetPassword(string password)
		{
			this.GetPasswordField().SendKeys(password);
		}

		private IWebElement GetPasswordField()
		{
			return this.Driver.FindElement(By.Id("Password"));
		}

		private void SetUsername(string username)
		{
			this.GetUsernameField().SendKeys(username);
		}

		private IWebElement GetUsernameField()
		{
			return this.Driver.FindElement(By.Id("Email"));
		}
	}
}