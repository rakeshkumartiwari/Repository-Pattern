using System;
using System.Collections.Generic;
using System.Linq;
using EFCodeFirstAnimalDb.Domain;

namespace EFCodeFirstAnimalDb.Presentation
{
    public partial class SearchCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCat.aspx");
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCats.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var db = new AnimalDB();
            
              List<Cat> listCats = db.Cats.Where(c => c.Name == txtSearch.Text).ToList();

               if (listCats.Count == 0)
                {
                    lblError.Text = "Please check the name, this name is not registered.";
                }
                else
                {
                    gridSearch.DataSource = listCats.ToList();
                    gridSearch.DataBind();
                    lblError.Text = "";
                }
           
            
        }
    }
}