/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public interface IValidator<TAccount>
        where TAccount : UserAccount
    {
        ValidationResult Validate(UserAccountService service, TAccount account, string value);
    }
}
    