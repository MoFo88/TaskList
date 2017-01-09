using System.Collections.Generic;

namespace TaskList.Tasks.Dtos
{
    public class GetTasksOutput
    {
        public List<TaskDto> Tasks { get; set; }
    }
}