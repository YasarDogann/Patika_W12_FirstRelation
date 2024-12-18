using System.ComponentModel.DataAnnotations.Schema;

namespace patika_w12_FirstRelation.Entities
{
    [Table("Posts")]
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } // Foreign Key 

        public User User { get; set; } // her posta yalnızca bir user tarafına aittir.
    }
}
