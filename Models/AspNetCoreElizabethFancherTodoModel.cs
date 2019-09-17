using System;
using System.ComponentModel.DataAnnotations;

namespace ElizabethFancherTodo.Models
{
    public class ElizabethFancherTodoItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
    public class ElizabethFancherTodoViewModel
    {
        public ElizabethFancherTodoItem[] Items { get; set; }
    }
}
