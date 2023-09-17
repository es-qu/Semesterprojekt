using System;

namespace ContactManager.Entity
{
    internal class Note
    {
        private string id;
        private string content;
        string createTimestamp;
        string editTimestamp;

        public Note()
        {
            this.id = Guid.NewGuid().ToString();
            this.content = "";
            this.createTimestamp = DateTime.Now.ToString();
            this.editTimestamp = this.createTimestamp;
        }

        public Note(string content) : this()
        {
            this.content = content;
        }

        public Note(string id, string content, string timeCreated, string timeLastEdit) : this(content)
        {
            this.id = id;
            this.createTimestamp = timeCreated;
            this.editTimestamp = timeLastEdit;
        }

        public string Id { get { return id; } }
        public string Content
        {
            get { return content; }
            set { content = value; editTimestamp = DateTime.Now.ToString(); } // Update content edit timestamp
        }
        public string CreateTimestamp { get { return createTimestamp; } }
        public string EditTimestamp { get { return editTimestamp; } }
    }
}