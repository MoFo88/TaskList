using Abp.Web.Mvc.Views;

namespace TaskList.Web.Views
{
    public abstract class TaskListWebViewPageBase : TaskListWebViewPageBase<dynamic>
    {

    }

    public abstract class TaskListWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TaskListWebViewPageBase()
        {
            LocalizationSourceName = TaskListConsts.LocalizationSourceName;
        }
    }
}