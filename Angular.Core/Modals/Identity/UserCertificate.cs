/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.Identity
{
    public class UserCertificate : Entity
    {
        public Guid Id { get; set; }

        [StringLength(150)]
        [Required]
        public virtual string Thumbprint { get; protected internal set; }

        [StringLength(250)]
        public virtual string Subject { get; protected internal set; }

        public Guid UserId { get; set; }

        public UserAccount User { get; set; }
    }
}
