using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJs.Core.Modals;

namespace Angular.Data.ModalFactory
{
    public class ModalFactory
    {
        public class ModelFactory
        {


            public ModelFactory()
            {

            }

            public UserReturnModel Create(User appUser)
            {
                return new UserReturnModel
                {
                    
                    Id = appUser.Id,
                   

                };
            }
        }

        public class UserReturnModel
        {

            public Guid Id { get; set; }

           
           
        }
    }
}
