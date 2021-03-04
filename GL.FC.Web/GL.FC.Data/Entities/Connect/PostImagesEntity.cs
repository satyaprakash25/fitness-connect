using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Data
{
    [Table("PostImages")]
    public class PostImagesEntity : BaseEntity
    {
        public string ImagePath { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }

        public PostEntity Post { get; set; }
    }
}
