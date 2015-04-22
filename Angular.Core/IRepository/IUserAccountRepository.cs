/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using Angular.Core.Modals.Identity;

namespace Angular.Core.IRepository
{
    public interface IUserAccountRepository
       
    {
        UserAccount Create();
        void Add(UserAccount item);
        void Remove(UserAccount item);
        void Update(UserAccount item); 
        UserAccount GetByID(Guid id);
        UserAccount GetByUsername(string username);
        UserAccount GetByUsername(string tenant, string username);
        UserAccount GetByEmail(string tenant, string email);
        UserAccount GetByMobilePhone(string tenant, string phone);
        UserAccount GetByVerificationKey(string key);
        UserAccount GetByLinkedAccount(string tenant, string provider, string id);
        UserAccount GetByCertificate(string tenant, string thumbprint);
    }

}
