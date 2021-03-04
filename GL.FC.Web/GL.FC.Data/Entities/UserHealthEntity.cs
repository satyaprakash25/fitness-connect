using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GL.FC.Data
{
    [Table("UserHealth")]
    public class UserHealthEntity : BaseEntity
    {
        [ForeignKey("UserProfile")]
        public int UserId { get; set; }

        public UserProfileEntity UserProfile { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }
    }

}
