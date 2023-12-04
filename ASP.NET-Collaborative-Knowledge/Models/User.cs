namespace ASP.NET_Collaborative_Knowledge.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation property for one-to-many relationship
        public ICollection<Question> Questions { get; set; }
    }

}
