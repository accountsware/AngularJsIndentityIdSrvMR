using System.Collections.Generic;

namespace Angular.Core.CommandEventHandlers
{
    public interface IEventSource
    {
        IEnumerable<IEvent> GetEvents();
        void Clear();
    }
}
