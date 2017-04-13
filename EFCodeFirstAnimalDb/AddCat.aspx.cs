using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFCodeFirstAnimalDb
{
    public partial class AddCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchCat.aspx");
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCats.aspx");
        }
        public string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
        protected void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                var cat = new Cat { Id = GenerateId(),Name = txtName.Text, Color = txtColor.Text };
                var repository = new EfCatRepository();
                repository.Add(cat);
                Response.Redirect("ViewAllCats.aspx");
            }
            catch (Exception exception)
            {

                lblError.Text = exception.Message;
            }
           
        }


    }
}