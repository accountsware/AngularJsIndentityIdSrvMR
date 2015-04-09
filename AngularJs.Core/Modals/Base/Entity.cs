using System.ComponentModel.DataAnnotations.Schema;

namespace AngularJs.Core.Modals.Base
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}