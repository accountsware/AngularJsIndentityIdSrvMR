using System.ComponentModel.DataAnnotations.Schema;
using Angular.Data.IRepository.Base;

namespace Angular.Data.Modals.Base
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}