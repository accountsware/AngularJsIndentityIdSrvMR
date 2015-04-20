using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.Modals;
using Angular.Core.Modals.Identity;

namespace Angular.Data.ModalFactory
{
    public class ModalFactory
    {
        public class ModelFactory
        {


            public ModelFactory()
            {

            }

            public UserReturnModel Create(UserAccount appUser)
            {
                return new UserReturnModel
                {
                    
                
                   

                };
            }
        }

        public class UserReturnModel
        {

            public Guid Id { get; set; }

           
           
        }
    }
}
