using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Fullname { get; set; }
        public DateTime BirthDdate { get; set; }
    }
}
