
using System.ComponentModel.DataAnnotations.Schema;


namespace Angular.Core.Modals.Base
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}