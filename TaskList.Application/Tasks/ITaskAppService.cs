using Abp.Application.Services;
using TaskList.Tasks.Dtos;

namespace TaskList.Tasks
{
    public interface ITaskAppService: IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);
        void UpdateTask(UpdateTaskInput input);
        void CreateTask(CreateTaskInput input);
    }
}