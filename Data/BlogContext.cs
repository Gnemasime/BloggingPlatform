// Data/BlogContext.cs
using Microsoft.EntityFrameworkCore;
using BloggingPlatform.Models;

namespace BloggingPlatform.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
