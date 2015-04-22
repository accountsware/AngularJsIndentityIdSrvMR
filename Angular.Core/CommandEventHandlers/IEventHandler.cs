using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Core.IHandlers
{
    public interface IEventHandler { }
    public interface IEventHandler<in T> : IEventHandler
        where T : IEvent
    {
        void Handle(T evt);
    }
}
