using TaskList.Entities;

namespace TaskList.Tasks.Dtos
{
    public class GetTasksInput
    {
        public int? AssignedPersonId { get; set; }
        public TaskState? State { get; set; }
    }
}