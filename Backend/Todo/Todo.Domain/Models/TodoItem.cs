using System;

namespace Todo.Domain.Models
{
    public class TodoItem
    {
        private TodoItem() {}
        internal TodoItem(string title, string comment)
        {
            Title = title;
            Comment = comment;
            DateCreated = DateTime.UtcNow;
            DateUpdated = DateCreated;
        }
        
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Comment { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateUpdated { get; private set; }

        public void ChangeTitleAndComment(string title, string comment)
        {
            if (IsDone)
                throw new Exception("Can't change done task");
            Title = title;
            Comment = comment;
            DateUpdated = DateTime.UtcNow;
        }

        public void DoTheTask()
        {
            IsDone = true;
            DateUpdated = DateTime.UtcNow;
        }
    }
}