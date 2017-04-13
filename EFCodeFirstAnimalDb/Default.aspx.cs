using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFCodeFirstAnimalDb
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            AnimalDB db = new AnimalDB();
            GridView1.DataSource = db.Cats.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var db = new AnimalDB();
            
           GridView1.DataSource = db.Cats.Where(c => c.Name == TextBox1.Text ).ToList();
           GridView1.DataBind();

         
        }
    }

    
}