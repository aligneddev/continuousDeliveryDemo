using Common.SeleniumTools;
using OpenQA.Selenium;

namespace ContinuousDelivery.Web.UiMappings
{
	/// <summary>
	/// UI Mapping for the Home Page. This is a wrapper for all UI interactions. 
	/// </summary>
	public class HomePage : BaseMappingPage
	{
		public HomePage Login(string username, string password)
		{
			this.GetLoginLink().Click();
			var loginPage = new LoginPage();
			loginPage.Login(username, password);
			return new HomePage();
		}
		private IWebElement GetLoginLink()
		{
			return this.Driver.FindElement(By.Id("loginLink"));
		}

		public HomePage RegisterUser(string userName, string password)
		{
			this.GetRegisterLink().Click();
			var registerPage = new RegisterPage();
			return registerPage.RegisterUser(userName, password);
		}

		private IWebElement GetRegisterLink()
		{
			return this.Driver.FindElement(By.Id("registerLink"));
		}

		public string GetAuthenticatedHeaderMessage()
		{
			var element = this.Driver.FindElement(By.Id("auto-AuthenticatedHeaderHello"));
			return element == null ? string.Empty : element.Text;
		}
	}
}