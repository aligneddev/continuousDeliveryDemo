using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SeleniumTools
{
	/// <summary>
	/// The browser type.
	/// </summary>
	public enum BrowserType
	{
		/// <summary>
		/// The IE browser
		/// </summary>
		Ie,

		/// <summary>
		/// Microsoft Edge browser.
		/// </summary>
		Edge, 

		/// <summary>
		/// The firefox.
		/// </summary>
		Firefox,

		/// <summary>
		/// The chrome.
		/// </summary>
		Chrome,
		/// <summary>
		/// Phantom JS headless browser
		/// </summary>
		PhantomJs
	}
}
