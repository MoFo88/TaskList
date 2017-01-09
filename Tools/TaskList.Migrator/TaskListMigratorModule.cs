using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TaskList.EntityFramework;

namespace TaskList.Migrator
{
    [DependsOn(typeof(TaskListDataModule))]
    public class TaskListMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaskListDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}