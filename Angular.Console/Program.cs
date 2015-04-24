
using System;
using Angular.Common;
using Angular.Core.Modals;
using Angular.Core.Modals.Base;
using Angular.Core.Modals.Identity;
using Angular.Data;
using Angular.Data.Context;
using Angular.Data.Repository;
using Angular.Data.Repository.@base;
using Angular.Services;
using Angular.Services.Base;
using BrockAllen.MembershipReboot;


namespace Angular.Console
{
    class Program
    {


        static void Main(string[] args)
        {
            var db = new AngularContext();
            var uow = new UnitOfWork(db);
            var repo = new Repository<UserAccount>(db, uow);
           // var serv = new Service<UserAccount>(repo);


            var usrv = new UserAccountService(new UserAccountRepository(repo));

          //  usrv.CreateAccount("default", "me2@you.com", "me@you.com", "me@you.com");

        //    uow.SaveChanges();

            var user = usrv.GetByEmail("default","me@you.com");
            System.Console.WriteLine(user.ID);

            System.Console.ReadLine();




        }
    }
}
