using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussIt.Views
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            if (u != null)
            {
                LoginPanel.Visible = true;
                PostPanel.Visible = true;
                GuestPanel.Visible = false;
                ProfileName.Text = u.UserName;
            }
            else
            {
                PostPanel.Visible = false;
                LoginPanel.Visible = false;
                GuestPanel.Visible = true;
            }
        }

        protected void CreatePostLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePostPage.aspx");
        }
    }
}