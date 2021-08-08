using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Wizemen.NET.Models
{
    /// <summary>
    /// Credentials object used to authenticate user
    /// </summary>
    public class Credentials
    {
        private readonly Dictionary<SchoolCode, string> _schoolNameByCode = new()
        {
            {SchoolCode.Psn, "Pathways School Noida"},
            {SchoolCode.Psg, "Pathways School Gurgaon"},
            {SchoolCode.Pws, "Pathways World School, Aravali"}
        };
        
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
            SchoolName = _schoolNameByCode[schoolCode];
        }
        
        /// <summary>
        /// The user's Wizemen Email
        /// </summary>
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
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
        /// The school's Name (Auto generated depending on the <see cref="SchoolCode"/>)
        /// </summary>
        public string SchoolName { get; }
    }
}