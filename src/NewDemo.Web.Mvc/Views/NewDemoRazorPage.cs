using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace NewDemo.Web.Views
{
    public abstract class NewDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected NewDemoRazorPage()
        {
            LocalizationSourceName = NewDemoConsts.LocalizationSourceName;
        }
    }
}
