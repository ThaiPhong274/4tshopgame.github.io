using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoanWebNhomPV
{
    public partial class dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBox1.Text;
            string pass = TextBox2.Text;
            string repass = TextBox3.Text;
            string hoten = TextBox4.Text;
            bool flag = true;
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(repass) || String.IsNullOrEmpty(hoten))
            {
                Label4.Visible = true;
                flag = false;
            }
            if (!IsValidEmail(email))
            {
                Label1.Visible = true;
                flag = false;
            }             
            if (pass.Length < 6)
            {
                Label2.Visible = true;
                flag = false;
            }
                
            if (!pass.Equals(repass))
            {
                Label3.Visible = true;
                flag = false;
            }
            if (flag == true)
            {
                if (KHACHHANGDAO.CreateNewKH(email, pass, hoten))
                    Response.Redirect("dangnhap.aspx");
                else
                    Label5.Visible = true;
            }
            else
                return;
        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}