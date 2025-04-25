namespace IntelliNotes.Domain.Entities
{
    public class User
    {
        public User(string userName, string email)
        {
            UserName = userName;
            Email = email;
            Id = Guid.NewGuid();
            Role = "User";

            CreatedAt = DateTime.Now;
            Notes = new List<Note>();
        }

        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; } = string.Empty;
        public string Role { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public ICollection<Note> Notes { get; private set; }
    }
}
