using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaskList.EntityFramework.Repositories
{
    public abstract class TaskListRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaskListDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaskListRepositoryBase(IDbContextProvider<TaskListDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TaskListRepositoryBase<TEntity> : TaskListRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaskListRepositoryBase(IDbContextProvider<TaskListDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
