using System.Web.Mvc;
using Newtonsoft.Json;

namespace Truefit.KnockoutDemo.Web.Infrastructure.Helpers
{
    public static class JsonHtmlHelper
    {
        public static MvcHtmlString Json<TModel, TObject>(this HtmlHelper<TModel> html, TObject obj)
        {
            return MvcHtmlString.Create(JsonConvert.SerializeObject(obj));
        }
    }
}