using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;

namespace EFCodeFirstAnimalDb
{
    public class ReCreateDataBaseIfModelChanges : DropCreateDatabaseIfModelChanges<AnimalDB>
    {
        protected override void Seed(AnimalDB context)
        {
            context.Seed(context);

            base.Seed(context);
        }
    }


    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //asking entityframework to recreate db if model changes else ignore.
            Database.SetInitializer<AnimalDB>(new ReCreateDataBaseIfModelChanges());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}