namespace Angular.Core.CommandEventHandlers
{
    public interface ICommandBus
    {
        void Execute(ICommand cmd);
    }
}
