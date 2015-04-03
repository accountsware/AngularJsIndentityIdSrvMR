using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Data.IRepository;
using Angular.Data.IRepository.Base;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Angular.Services.Base;

namespace Angular.Services.Service
{
    public class PersonService: BaseService,IPersonService
    {
        private IPersonRepository _personRepository;
        private IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork, IPersonRepository personRepository) 
            
           : base(unitOfWork)
        {
            _personRepository = personRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddPerson(Person prsn)
        {
            var person = new Person();

            person.FirstName = prsn.FirstName;
            person.LastName = prsn.LastName;       
            _personRepository.Add(person);
            _unitOfWork.SaveChanges();
            

        }
    }
}
