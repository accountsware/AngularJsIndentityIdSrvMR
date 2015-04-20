﻿/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.Identity
{
    public class PasswordResetSecret : Entity
    {
        public virtual Guid PasswordResetSecretID { get; protected internal set; }

        [StringLength(150)]
        [Required]
        public virtual string Question { get; protected internal set; }

        [StringLength(150)]
        [Required]
        public virtual string Answer { get; protected internal set; }
        public Guid UserId { get; set; }

        public UserAccount User { get; set; }
    }
}
