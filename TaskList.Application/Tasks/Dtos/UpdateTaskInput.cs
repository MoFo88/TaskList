﻿using System.ComponentModel.DataAnnotations;
using Abp.Runtime.Validation;
using TaskList.Entities;

namespace TaskList.Tasks.Dtos
{
    public class UpdateTaskInput : ICustomValidate
    {
        [Range(1, long.MaxValue)]
        public long TaskId { get; set; }
        public TaskState? State { get; set; }
        public int? AssignedPersonId { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (AssignedPersonId == null && State == null)
            {
                context.Results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", new[] { "AssignedPersonId", "State" }));
            }
        }

        public override string ToString()
        {
            return $"[UpdateTaskInput > TaskId = {TaskId}, AssignedPersonId = {AssignedPersonId}, State = {State}]";
        }
    }
}