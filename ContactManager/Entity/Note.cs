using System;
using System.Globalization;

namespace ContactManager.Entity
{
    // this class is for contact notes
    internal class Note
    {
        // fields
        private string id;
        private string content;
        private string createTimestamp;
        private string editTimestamp;

        // constructors
        public Note()
        {
            this.id = Guid.NewGuid().ToString();
            this.content = "";
            this.createTimestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
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

        // properties
        public string Id { get { return id; } }

        public string Content
        {
            get { return content; }
            set { content = value; editTimestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture); } // Update content edit timestamp
        }
        public string CreateTimestamp { get { return createTimestamp; } }
        public string EditTimestamp { get { return editTimestamp; } }

    }
}