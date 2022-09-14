using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Globoticket.Web.Pages
{
    public class SetLanguageModel : PageModel
    {
        public IActionResult OnGet(string cultureName)
        {
            var culture = new RequestCulture(cultureName);
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(culture));

            var referrer = Request.GetTypedHeaders()?.Referer;

            //TODO: verify whether referrer is correct and a local URI
            return Redirect(referrer?.ToString() ?? "~/");
        }
    }
}
