/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.Identity
{
    public class TwoFactorAuthToken : Entity
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public virtual string Token { get; protected internal set; }

        public virtual DateTime Issued { get; protected internal set; }
        public Guid UserId { get; set; }

        public UserAccount User { get; set; }
    }
}
