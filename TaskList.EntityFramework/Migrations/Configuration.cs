using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TaskList.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using TaskList.Entities;

namespace TaskList.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<TaskList.EntityFramework.TaskListDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TaskList";
        }

        protected override void Seed(TaskList.EntityFramework.TaskListDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.People.AddOrUpdate(
                p => p.Name,
                new Person { Name = "Isaac Asimov" },
                new Person { Name = "Thomas More" },
                new Person { Name = "George Orwell" },
                new Person { Name = "Douglas Adams" }
                );

            context.SaveChanges();
        }
    }
}
