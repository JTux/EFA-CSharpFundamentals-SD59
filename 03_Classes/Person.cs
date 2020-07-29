using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Person
    {
        // Properties: First Name, Last Name, Full Name, Date Of Birth, Age
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                // Take the DateOfBirth and figure how long it's been since then
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                // Calculate our age based off the TimeSpan
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                // Convert our double years into an int
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
    }
}
