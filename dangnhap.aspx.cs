using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoanWebNhomPV
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            KHACHHANG kh = KHACHHANGDAO.Login(username, password);
            if (kh.email != null)
            {
                Session["LoginID"+Session.SessionID] = kh.makh;
                Session["LoginName" + Session.SessionID] = kh.hotenkh;
                Response.Redirect("index.aspx");
            }
            else
                Label1.Visible = true;
        }
    }
}