using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NsisongInvoiceV1.Models
{
    public class Organisation
    {
        public long Id { get; set; } // internal ID
        public string? Name { get; set; } // Main organisation name
        public int OrganisationId { get; set; } // public facing organisation ID
        public string? OfficialName { get; set; } // Official name
        public string? Address { get; set; }
        public int OwnerId { get; set; }
        public string? Phone { get; set; }
        public bool IsVerified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime VerifiedAt    { get; set; }
        public string? PermissionObject { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
