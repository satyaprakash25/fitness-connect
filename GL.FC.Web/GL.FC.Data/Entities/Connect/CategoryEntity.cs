using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Data
{
    [Table("Category")]
    public class CategoryEntity : BaseEntity
    {
        public string BgColor { get; set; }
    }
}
