using System;

namespace ContactManager.Entity
{
    internal class Note
    {
        private string id;
        private string content;
        DateTime timestamp;

        public Note()
        {
            this.id = Guid.NewGuid().ToString();
            this.content = "";
            this.timestamp = DateTime.Now;
        }

        public Note(string content) : base()
        {
            this.content = content;
        }

        public string Id { get { return id; } set { id = value; } }
        public string Content { get { return content; } set { content = value; } }
        public DateTime Timestamp { get { return timestamp; } }
    }
}
