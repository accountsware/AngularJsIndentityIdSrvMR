
using System.ComponentModel.DataAnnotations.Schema;


namespace AngularJs.Core.Modals.Base
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}