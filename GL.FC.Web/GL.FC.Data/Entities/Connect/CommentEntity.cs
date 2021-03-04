using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Data
{
    [Table("Comment")]
    public class CommentEntity : BaseEntity
    {
        public string Description { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }

        public PostEntity Post { get; set; }

        [ForeignKey("CommentedBy")]
        public int CommentedById { get; set; }

        public UserProfileEntity CommentedBy { get; set; }
    }
}
