using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace TaskList.Entities
{
    public class Task : Entity<long>
    {
        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }

        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }

        public virtual int? AssignedPersonId { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual TaskState State { get; set; }
    }

    /// <summary>
    /// Possible states of a <see cref="Task"/>.
    /// </summary>
    public enum TaskState : byte
    {
        /// <summary>
        /// The task is active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The task is completed.
        /// </summary>
        Completed = 2
    }
}