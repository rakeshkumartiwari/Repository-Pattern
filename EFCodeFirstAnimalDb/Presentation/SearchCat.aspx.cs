using System;
using System.Data;
using EFCodeFirstAnimalDb.Infrastructure;

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
            var repository = new SqlCatRepository();
            DataSet objDataSet = repository.GetCatByName(txtSearch.Text);

            if (objDataSet.Tables[0].Rows.Count == 0)
            {
                lblError.Text = "Please check the name, this name is not registered.";
            }
            else
            {
                gridSearch.DataSource = objDataSet;
                gridSearch.DataBind();
            }
            

            #region Using Entity Framework

            //var repository = new EfCatRepository();

            //List<Cat> catList = repository.GetCatByName(txtSearch.Text);


            //if (catList.Count == 0)
            //{
            //    lblError.Text = "Please check the name, this name is not registered.";
            //}
            //else
            //{
            //    gridSearch.DataSource = catList;
            //    gridSearch.DataBind();
            //    lblError.Text = "";
            //}

            #endregion

        }
    }
}