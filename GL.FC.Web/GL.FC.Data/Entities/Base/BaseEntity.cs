using System;
using System.Collections.Generic;
using System.Text;

namespace GL.FC.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
