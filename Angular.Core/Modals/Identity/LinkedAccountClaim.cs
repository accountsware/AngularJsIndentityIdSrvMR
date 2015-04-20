using System;
using System.ComponentModel.DataAnnotations;

namespace Angular.Core.Modals.Identity
{
    public class LinkedAccountClaim
    {
        [StringLength(30)]
        [Required]
        public virtual string ProviderName { get; protected internal set; }
        [StringLength(100)]
        [Required]
        public virtual string ProviderAccountID { get; protected internal set; }
        [StringLength(150)]
        [Required]
        public virtual string Type { get; protected internal set; }
        [StringLength(150)]
        [Required]
        public virtual string Value { get; protected internal set; }
        public Guid UserId { get; set; }

        public UserAccount User { get; set; }
    }
}
