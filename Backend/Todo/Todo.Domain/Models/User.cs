using System;
using System.Collections.Generic;

namespace Todo.Domain.Models
{
    public class User
    {
        private List<TodoItem> _todoItems = new List<TodoItem>();

        private User() {}
        public User(Guid userId, string name)
        {
            ChangeName(name);
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyCollection<TodoItem> TodoItems => _todoItems;

        public void ChangeName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Can't set empty name");
            
            Name = name;
        }
        public void AddItem(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public void RemoveItem(TodoItem item)
        {
            _todoItems.Remove(item);
        }
        
    }
}