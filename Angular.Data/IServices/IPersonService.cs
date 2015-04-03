
using Angular.Data.IServices.Base;
using Angular.Data.Modals;

namespace Angular.Data.IServices
{
    public interface IPersonService: IService
    {
        void AddPerson(Person prsn);
    }
}
