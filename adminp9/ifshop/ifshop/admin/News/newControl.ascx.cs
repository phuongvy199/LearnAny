using System;

namespace ifshop.admin.News
{
    public partial class newControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controls.Add(LoadControl("newCatogri.ascx"));
        }
    }
}