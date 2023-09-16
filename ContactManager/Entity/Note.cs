using System;

namespace ContactManager.Entity
{
    public class Note
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateTimestamp { get; private set; }
        public DateTime EditTimestamp { get; private set; }

        public Note(string id, string content)
        {
            Id = id;
            Content = content;
            CreateTimestamp = DateTime.Now; // Note is created now
            EditTimestamp = DateTime.MinValue; // Note is not edited yet
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
            EditTimestamp = DateTime.Now; // Note is edited now
        }
    }
}