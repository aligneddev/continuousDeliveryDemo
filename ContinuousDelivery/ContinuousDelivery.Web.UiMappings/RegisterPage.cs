using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ContinuousDelivery.Web.UiMappings
{
	/// <summary>
	/// UI mappings for the register page.
	/// </summary>
	internal class RegisterPage : BaseMappingPage
	{
		/// <summary>
		/// Register the user with the given username and password.
		/// Redirected to homepage after success.
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public HomePage RegisterUser(string userName, string password)
		{
			this.GetEmailInput().SendKeys(userName);
			this.GetPasswordOneInput().SendKeys(password);
			this.GetConfirmPasswordInput().SendKeys(password);
			this.GetSubmitButton().Click();

			// NOTE: building in a loading indicator and waiting for the div to 
			// be removed from the page will help you avoid timing issues in your tests
			// for example: the UI may run faster than your web server and browser processes
			// and it will try to click on a link that isn't loaded yet.
			return new HomePage();
		}

		private IWebElement GetSubmitButton()
		{
			return this.Driver.FindElement(By.Id("auto-registerSubmitButton"));
		}

		private IWebElement GetEmailInput()
		{
			return this.Driver.FindElement(By.Id("Email"));
		}

		private IWebElement GetPasswordOneInput()
		{
			return this.Driver.FindElement(By.Id("Password"));
		}

		private IWebElement GetConfirmPasswordInput()
		{
			return this.Driver.FindElement(By.Id("ConfirmPassword"));
		}
	}
}
