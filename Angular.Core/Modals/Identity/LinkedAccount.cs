using System;
using System.ComponentModel.DataAnnotations;

namespace Angular.Core.Modals.Identity
{
    public class LinkedAccount
    {
        [StringLength(30)]
        [Required]
        public virtual string ProviderName { get; protected internal set; }
        [StringLength(100)]
        [Required]
        public virtual string ProviderAccountID { get; protected internal set; }
        public Guid UserId { get; set; }

        public UserAccount User { get; set; }

        public virtual DateTime LastLogin { get; protected internal set; }
    }
}