using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElizabethFancherTodo.Models;

namespace ElizabethFancherTodo.Services
{
    
    public interface IElizabethFancherTodoItemService
    {
        Task<ElizabethFancherTodoItem[]> GetIncompleteItemsAsync();
    }

    
    public class FakeTodoItemService : IElizabethFancherTodoItemService
    {
        public Task<ElizabethFancherTodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new ElizabethFancherTodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new ElizabethFancherTodoItem
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
