using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NsisongInvoiceV1.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public int OrganisationId { get; set; }
        public string? Meta { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
