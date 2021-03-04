using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Data
{
    [Table("Post")]
    public class PostEntity : BaseEntity
    {
        public string Heading { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Tags { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; }

        [ForeignKey("CreatedByUser")]
        public int CreatedBy { get; set; }

        public UserProfileEntity CreatedByUser { get; set; }

        public IList<PostImagesEntity> PostImages { get; set; }
    }
}
