using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rss.Search.Model;

namespace Rss.Search.DataAccess.Context
{
    public class RssSearchDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public RssSearchDbContext(DbContextOptions<RssSearchDbContext> options) : base(options)
        {

        }
    }
}