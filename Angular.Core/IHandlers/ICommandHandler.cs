using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Core.IHandlers
{
    public interface ICommandHandler { }
    public interface ICommandHandler<in TCommand> : ICommandHandler
        where TCommand : ICommand
    {
        void Handle(TCommand cmd);
    }
}
