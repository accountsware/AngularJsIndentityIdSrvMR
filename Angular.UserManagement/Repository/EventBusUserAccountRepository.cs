/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using Angular.Core.CommandEventHandlers;
using Angular.Core.IRepository;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public class EventBusUserAccountRepository : IUserAccountRepository
        
    {
        IEventSource source;
        internal IUserAccountRepository inner;
        IEventBus validationBus;
        IEventBus eventBus;

        public EventBusUserAccountRepository(IEventSource source, IUserAccountRepository inner, IEventBus validationBus, IEventBus eventBus)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (inner == null) throw new ArgumentNullException("inner");
            if (validationBus == null) throw new ArgumentNullException("validationBus");
            if (eventBus == null) throw new ArgumentNullException("eventBus");

            this.source = source;
            this.inner = inner;
            this.validationBus = validationBus;
            this.eventBus = eventBus;
        }

        private void RaiseValidation()
        {
            foreach (var evt in source.GetEvents())
            {
                this.validationBus.RaiseEvent(evt);
            }
        }

        private void RaiseEvents()
        {
            foreach (var evt in source.GetEvents())
            {
                this.eventBus.RaiseEvent(evt);
            }

            source.Clear();
        }

        public UserAccount Create()
        {
            return inner.Create();
        }

        public void Add(UserAccount item)
        {
            RaiseValidation();
            inner.Add(item);
            RaiseEvents();
        }

        public void Remove(UserAccount item)
        {
            RaiseValidation();
            inner.Remove(item);
            RaiseEvents();
        }

        public void Update(UserAccount item)
        {
            RaiseValidation();
            inner.Update(item);
            RaiseEvents();
        }

        public UserAccount GetByID(Guid id)
        {
            return inner.GetByID(id);
        }

        public UserAccount GetByUsername(string username)
        {
            return inner.GetByUsername(username);
        }

        public UserAccount GetByUsername(string tenant, string username)
        {
            return inner.GetByUsername(tenant, username);
        }

        public UserAccount GetByEmail(string tenant, string email)
        {
            return inner.GetByEmail(tenant, email);
        }

        public UserAccount GetByMobilePhone(string tenant, string phone)
        {
            return inner.GetByMobilePhone(tenant, phone);
        }

        public UserAccount GetByVerificationKey(string key)
        {
            return inner.GetByVerificationKey(key);
        }

        public UserAccount GetByLinkedAccount(string tenant, string provider, string id)
        {
            return inner.GetByLinkedAccount(tenant, provider, id);
        }

        public UserAccount GetByCertificate(string tenant, string thumbprint)
        {
            return inner.GetByCertificate(tenant, thumbprint);
        }
    }
}
