using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Shared
{
    public class PostImagesModel : ModelBase
    {
        public string ImagePath { get; set; }

        public int PostId { get; set; }

        public PostModel Post { get; set; }
    }
}
