using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Core.IHandlers
{
    public interface IEventSource
    {
        IEnumerable<IEvent> GetEvents();
        void Clear();
    }
}
