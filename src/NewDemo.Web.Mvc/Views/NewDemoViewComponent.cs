using Abp.AspNetCore.Mvc.ViewComponents;

namespace NewDemo.Web.Views
{
    public abstract class NewDemoViewComponent : AbpViewComponent
    {
        protected NewDemoViewComponent()
        {
            LocalizationSourceName = NewDemoConsts.LocalizationSourceName;
        }
    }
}
