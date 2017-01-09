using System.Collections.Generic;
using Abp.Domain.Repositories;
using TaskList.Entities;

namespace TaskList.Repositories
{
    public interface ITaskRepository : IRepository<Task, long>
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
    }
}