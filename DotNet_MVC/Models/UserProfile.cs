using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_Mvc.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
         //if we have concate first middle name to create full name
         // public string FullName = $"{firstname} {lastname}"
        public string JobTitle { get; set; }
        
    }
}
