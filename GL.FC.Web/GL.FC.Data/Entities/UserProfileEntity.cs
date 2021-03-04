using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GL.FC.Data
{
    [Table("UserProfile")]
    public class UserProfileEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string ImagePath { get; set; }

        private IList<UserHealthEntity> userHealthDetails;

        public IList<UserHealthEntity> UserHealthDetails
        {
            get { return userHealthDetails ?? new List<UserHealthEntity>(); }
            set { userHealthDetails = value; }
        }
    }
}
