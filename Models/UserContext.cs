using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace NsisongInvoiceV1.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) 
            : base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
