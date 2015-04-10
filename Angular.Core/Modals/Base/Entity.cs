using System.ComponentModel.DataAnnotations.Schema;

namespace Angular.Core.Modals.Base
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}