namespace IntelliNotes.Domain.Entities
{
    public class Note
    {
        public Note(string title, string content)
        {
            Title = title;
            Content = content;

            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string? Summary { get; private set; }
        public string? Category { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public User User { get; set; }
    }
}
