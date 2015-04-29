using System;

namespace Angular.Core.CommandEventHandlers
{
    public class DelegateCommandHandler<TCommand> : ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Action<TCommand> action;
        public DelegateCommandHandler(Action<TCommand> action)
        {
            this.action = action;
        }

        public void Handle(TCommand cmd)
        {
            action(cmd);
        }
    }
}
