using System;
using EFCodeFirstAnimalDb.Infrastructure;

namespace EFCodeFirstAnimalDb.Presentation
{
    public partial class ViewAllCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region Using Sql
                var repository = new SqlCatRepository();
                repository.GetCats();
                gridViewAllCats.DataSource = repository.GetCats();
                gridViewAllCats.DataBind();
                #endregion
                #region Using Entity Framework
                //var repository = new EfCatRepository();
                //gridViewAllCats.DataSource = repository.GetAllCats();
                //gridViewAllCats.DataBind();
                #endregion
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchCat.aspx");
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCat.aspx");
        }

       

        protected void gridViewAllCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = gridViewAllCats.SelectedRow.Cells[1].Text;
            Session["SelectedId"] = selectedId;
            Response.Redirect("UpdateCat.aspx");
        }

        
       
    }
}