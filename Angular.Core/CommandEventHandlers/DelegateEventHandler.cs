using System;

namespace Angular.Core.CommandEventHandlers
{
    public class DelegateEventHandler<T> : IEventHandler<T>
        where T : IEvent
    {
        Action<T> action;
        public DelegateEventHandler(Action<T> action)
        {
            if (action == null) throw new ArgumentNullException("action");
            this.action = action;
        }

        public void Handle(T evt)
        {
            action(evt);
        }
    }
}
