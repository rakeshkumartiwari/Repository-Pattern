using System;

namespace EFCodeFirstAnimalDb
{
    public partial class UpdateCat : System.Web.UI.Page
    {
        readonly EfCatRepository _repository = new EfCatRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Session["SelectedId"].ToString();
                Cat cat = _repository.GetCatById(id);
                txtName.Text = cat.Name;
                txtColor.Text = cat.Color;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Session["SelectedId"].ToString();
           var cat = new Cat{Id=id,Name = txtName.Text,Color = txtColor.Text};
            _repository.Update(cat);
            Response.Redirect("ViewAllCats.aspx");
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllCats.aspx");
        }



    }
}