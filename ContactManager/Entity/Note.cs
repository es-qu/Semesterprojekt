using System;

namespace ContactManager.Entity
{
    public class Note
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateTimestamp { get; private set; }
        public DateTime EditTimestamp { get; private set; }


        public Note()
        {
            this.CreateTimestamp = DateTime.Now;
            this.EditTimestamp = this.CreateTimestamp;
        }


        public Note(string id, string content) : this()
        {
            Id = id;
            Content = content;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
            EditTimestamp = DateTime.Now;
        }
    }
}