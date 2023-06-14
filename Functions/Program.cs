using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Id = 1;
            userDetails.Name = "Charmi";
            userDetails.Email = "charmisurati1@gmail.com";
            userDetails.Countrycode = "+1";
            userDetails.AddressLine1 = "312 Black Dr";
            userDetails.AddressLine2 = "Milton";
            userDetails.Pincode = "L9T6S2";
            userDetails.PhoneNumber = "6475708368";
            userDetails.Gender = "F";
            userDetails.IsActive = true;
            userDetails.Height = 5.4;

            Console.WriteLine(userDetails.Name);

            GetAddress(userDetails);
            GetUserStatus(userDetails);

            Console.ReadKey();

        }

        public static string GetAddress(UserDetails userDetails)
        {
            string fullAddress = $"{userDetails.AddressLine1}, {userDetails.AddressLine2}, {userDetails.Pincode}";
            Console.WriteLine(fullAddress);
            return fullAddress;
        }

        public static bool GetUserStatus(UserDetails userDetails)
        {
            string activeData;
            if (userDetails.IsActive)
            {
                activeData = "active";
            }
            else activeData = "deactive";

            Console.WriteLine($"{userDetails.Name} is {activeData} user"); 
            return userDetails.IsActive;

        }

    }


    public class UserDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Countrycode { get; set; }
        public string PhoneNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string Gender { get; set; }

        public bool IsActive { get; set; }


    public double Height { get; set; }
}
}
