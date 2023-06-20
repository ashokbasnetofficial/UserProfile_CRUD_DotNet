using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_Mvc.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        [MinLength(10)]
        public string FullName { get; set; } = null!;
        [Required]
        [DisplayName("Phone No.")]
        [MinLength(10)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; } = null!;
        //if we have concate first middle name to create full name
        // public string FullName = $"{firstname} {lastname}"
        [Required]
        [DisplayName("JobTitle")]
        [MinLength(3)]
        public string JobTitle { get; set; }=null!;
        
    }
}
