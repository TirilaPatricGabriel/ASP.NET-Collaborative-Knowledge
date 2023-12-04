using System.ComponentModel.DataAnnotations;
namespace ASP.NET_Collaborative_Knowledge.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public User User { get; set; }
    }

}
