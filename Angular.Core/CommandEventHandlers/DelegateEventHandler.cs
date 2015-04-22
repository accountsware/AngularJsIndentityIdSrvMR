using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Core.IHandlers
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
