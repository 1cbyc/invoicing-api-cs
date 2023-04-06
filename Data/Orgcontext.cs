using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NsisongInvoiceV1.Models;

namespace NsisongInvoiceV1.Data
{
    public class OrgContext : DbContext
    {
        public OrgContext (DbContextOptions<OrgContext> options)
            : base(options)
        {
        }

        public DbSet<NsisongInvoiceV1.Models.Organisation>? Organisation { get; set; }
    }
}
