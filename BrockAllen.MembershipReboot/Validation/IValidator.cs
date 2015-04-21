/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public interface IValidator
       
    {
        ValidationResult Validate(UserAccountService service, UserAccount account, string value);
    }
}
    