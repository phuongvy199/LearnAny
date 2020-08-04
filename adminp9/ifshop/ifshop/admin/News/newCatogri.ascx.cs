using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ifshop.DAL;
namespace ifshop.admin.News
{
    public partial class newCatogri : System.Web.UI.UserControl
    {
        clsNew _new = new clsNew();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        void LoadData()
        {
            rptnew.DataSource = _new.GetList();
            rptnew.DataBind();
        }

        protected void addnew_Click(object sender, EventArgs e)
        {
            mul.ActiveViewIndex = 1;
        }

        //protected void btn_Click(object sender, EventArgs e)
        //{
        ////    if (!string.IsNullOrEmpty(txtMA.Text.Trim()))
        ////    {
        ////        _new.Insert(txtMA.Text.Trim(), int.Parse(txtTEN.Text.Trim()));
        ////        Response.Redirect(Request.Url.ToString());
        // //   }
        //}

        protected void btn_Save(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMA.Text.Trim()))
            {
                _new.Insert(txtMA.Text.Trim(), txtTEN.Text.Trim(), txtMALOAI.Text.Trim());
                Response.Redirect(Request.Url.ToString());
            }
        }
    }
}