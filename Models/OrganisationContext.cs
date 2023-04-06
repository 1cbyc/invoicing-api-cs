using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace NsisongInvoiceV1.Models
{
    public class OrganisationContext : DbContext
    {
        public OrganisationContext(DbContextOptions<OrganisationContext> options)
            : base(options)
        {
        }

        public DbSet<Organisation> Organisations { get; set; }
    }
}
