using System;
using System.Collections.Generic;
using System.Text;

namespace GL.FC.Shared
{
    public class ModelBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

    }
}
