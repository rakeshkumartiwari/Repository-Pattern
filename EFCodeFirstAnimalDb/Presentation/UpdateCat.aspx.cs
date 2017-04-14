using System;
using System.Data;
using EFCodeFirstAnimalDb.Domain;
using EFCodeFirstAnimalDb.Infrastructure;

namespace EFCodeFirstAnimalDb.Presentation
{
    public partial class UpdateCat : System.Web.UI.Page
    {
        readonly EfCatRepository _repository = new EfCatRepository();
        readonly SqlCatRepository _sqlRepository = new SqlCatRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Session["SelectedId"].ToString();
                #region Using Sql
                DataSet objDataSet = _sqlRepository.GetCatById(id);

                foreach (DataRow row in objDataSet.Tables[0].Rows)
                {
                    txtName.Text = row["Name"].ToString();
                    txtColor.Text = row["Color"].ToString();
                }
                #endregion
                #region Using Entity Framework
                //Cat cat = _repository.GetCatById(id);
                //txtName.Text = cat.Name;
                //txtColor.Text = cat.Color;
                #endregion
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Session["SelectedId"].ToString();
            #region Using Sql
            var cat = new Cat { Id = id, Name = txtName.Text, Color = txtColor.Text };
            _sqlRepository.Update(cat);
            #endregion

            #region Using Entity Framework
            // var cat = new Cat{Id=id,Name = txtName.Text,Color = txtColor.Text};
            //_repository.Update(cat);
            #endregion

            Response.Redirect("ViewAllCats.aspx");
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCats.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = Session["SelectedId"].ToString();
            #region Using Sql
            _sqlRepository.Delete(id);
            #endregion

            #region Using Entity Framework
            //_repository.Delete(id);
            #endregion

            Response.Redirect("ViewAllCats.aspx");
        }



    }
}