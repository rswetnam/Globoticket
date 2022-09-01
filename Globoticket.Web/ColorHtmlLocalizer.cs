using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace Globoticket.Web
{
    public class ColorHtmlLocalizer : IHtmlLocalizer
    {
        public LocalizedHtmlString this[string name] => 
            new LocalizedHtmlString(name, $"<span style='color: #{RandomColor}'>{name}</span>");

        public LocalizedHtmlString this[string name, params object[] arguments]
        {
            get
            {
                var value = string.Format(name, arguments);
                return new LocalizedHtmlString(name, $"<span style='color: #{RandomColor}'>{value}</span>");
            }
        } 

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new NotImplementedException();
        }

        public LocalizedString GetString(string name)
        {
            throw new NotImplementedException();
        }

        public LocalizedString GetString(string name, params object[] arguments)
        {
            throw new NotImplementedException();
        }

        private static string RandomColor => new Random().Next(0, 16777216).ToString("x6");
    }
}
