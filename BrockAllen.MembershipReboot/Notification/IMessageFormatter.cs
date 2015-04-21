/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */


using System.Collections.Generic;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public interface IMessageFormatter<TAccount>
        where TAccount : UserAccount
    {
        Message Format(UserAccountEvent accountEvent, IDictionary<string, string> values);
    }
}
