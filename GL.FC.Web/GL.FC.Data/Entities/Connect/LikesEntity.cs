using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GL.FC.Data
{
    [Table("Likes")]
    public class LikesEntity : BaseEntity
    {
        [ForeignKey("Post")]
        public int PostId { get; set; }

        public PostEntity Post { get; set; }

        [ForeignKey("LikedBy")]
        public int LikedById { get; set; }

        public UserProfileEntity LikedBy { get; set; }
    }
}
