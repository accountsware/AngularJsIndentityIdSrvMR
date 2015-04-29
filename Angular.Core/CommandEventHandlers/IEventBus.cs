namespace Angular.Core.CommandEventHandlers
{
    public interface IEventBus
    {
        void RaiseEvent(IEvent evt);
    }
}
