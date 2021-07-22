using System;
using System.Text.RegularExpressions;

namespace Wizemen.NET.Models
{
    public class Credentials
    {
        /// <summary>
        /// Creates the credentials object
        /// </summary>
        /// <param name="email">The user's Wizemen Email Address</param>
        /// <param name="password">The user's Wizemen Password</param>
        /// <param name="schoolCode">The user's SchoolCode</param>
        /// <exception cref="ArgumentException">Thrown if email provided was not in a correct format</exception>
        public Credentials(string email, string password, SchoolCode schoolCode)
        {
            var isEmailValid = Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
            if (!isEmailValid)
            {
                throw new ArgumentException("Email provided was not in a valid format");
            }

            Email = email;
            Password = password;
            SchoolCode = schoolCode;
            switch (schoolCode)
            {
                case SchoolCode.PSN:
                    SchoolName = "Pathways School Noida";
                    break;

                case SchoolCode.PSG:
                    SchoolName = "Pathways School Gurgaon";
                    break;

                case SchoolCode.PWS:
                    SchoolName = "Pathways World School, Aravali";
                    break;
            }
        }
        
        /// <summary>
        /// The user's Wizemen Email
        /// </summary>
        public string Email { get; }
        
        /// <summary>
        /// The user's Wizemen Password
        /// </summary>
        public string Password { get; }
        
        /// <summary>
        /// The user's Wizemen School Code
        /// </summary>
        public SchoolCode SchoolCode { get; }

        /// <summary>
        /// The school's Name
        /// </summary>
        public string SchoolName { get; set; }
    }
}