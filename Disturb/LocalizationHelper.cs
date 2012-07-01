using System.Threading;

namespace System.Web.Mvc
{
    public static class LocalizationHelper
    {
        public static IHtmlString MetaAcceptLanguage(this HtmlHelper html)
        {
            var acceptLang = HttpUtility.HtmlAttributeEncode(Thread.CurrentThread.CurrentUICulture.ToString());
            return new HtmlString(string.Format("<meta name=\"accept-language\" content=\"{0}\"/>", acceptLang));
        }
    }
}
