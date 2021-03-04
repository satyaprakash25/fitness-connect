using System;
using System.Collections.Generic;

namespace GL.FC.Shared
{
    public class UserProfileModel : ModelBase
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

        private IList<UserHealthModel> userHealthDetails;

        public IList<UserHealthModel> UserHealthDetails
        {
            get { return userHealthDetails ?? new List<UserHealthModel>(); }
            set { userHealthDetails = value; }
        }
    }
}
