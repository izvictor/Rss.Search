using Microsoft.AspNetCore.Identity;

namespace Rss.Search.Model
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}