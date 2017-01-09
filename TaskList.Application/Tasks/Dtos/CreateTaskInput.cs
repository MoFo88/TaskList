using System.ComponentModel.DataAnnotations;

namespace TaskList.Tasks.Dtos
{
    public class CreateTaskInput
    {
        [Required]
        public string Description { get; set; }
        public int? AssignedPersonId { get; set; }

        public override string ToString()
        {
            return $"[CreateTaskInput > AssignedPersonId = {AssignedPersonId}, Description = {Description}]";
        }
    }
}