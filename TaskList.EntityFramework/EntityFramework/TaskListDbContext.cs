using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using TaskList.Authorization.Roles;
using TaskList.Entities;
using TaskList.MultiTenancy;
using TaskList.Users;

namespace TaskList.EntityFramework
{
    public class TaskListDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TaskListDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TaskListDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TaskListDbContext since ABP automatically handles it.
         */
        public TaskListDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TaskListDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
