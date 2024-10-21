namespace QuickNotes.Core.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsArchived { get; set; }

        public bool IsDeleted { get; set; }
    }
}
