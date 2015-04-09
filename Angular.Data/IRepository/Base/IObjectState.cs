
using System.ComponentModel.DataAnnotations.Schema;


namespace Angular.Data.IRepository.Base
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}