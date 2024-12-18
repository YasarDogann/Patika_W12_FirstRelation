using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace patika_w12_FirstRelation.Entities
{
    [Table("Users")]
    public class User
    {
        [Key] // primary key olduğunu belirtiyoruz yazmasak da otomatik olarak algılıyor. Alıştırma için :(
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Post> Posts { get; set; } // bir kullanıcının birden fazla postası olabilir
    }
}
