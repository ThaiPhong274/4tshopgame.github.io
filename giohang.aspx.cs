using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace DoanWebNhomPV
{
    public partial class giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ID = Session["LoginID" + Session.SessionID];
                if (ID != null)
                {
                    LoadGH(Convert.ToInt32(ID));
                }
                else
                {
                    Label1.Text = "<h1>Có lỗi xảy ra bạn chưa đăng nhập</h1>";
                    Label1.Visible = true;
                }
                    
            }
        }

        private void LoadGH(int makh)
        {
            DataTable dt = GIOHANGDAO.getItem(makh);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            int masp = Convert.ToInt32(e.CommandArgument.ToString());
            int makh = Convert.ToInt32(Session["LoginID" + Session.SessionID]);
            if (e.CommandName == "RemoveItem")
            {
                if (GIOHANGDAO.UpdateItem(makh, masp, 0, true))
                    LoadGH(makh);
                else
                {
                    Label1.Text = "<h1>Lỗi không thể xoá sản phẩm</h1>";
                    Label1.Visible = true;
                }       
            }
            if(e.CommandName == "Tang")
            {
                if (GIOHANGDAO.UpdateItem(makh, masp, 1, true))
                    LoadGH(makh);
                else
                {
                    Label1.Text = "<h1>Lỗi không thể thêm sản phẩm</h1>";
                    Label1.Visible = true;
                }              
            }
            if (e.CommandName == "Giam")
            {
                if (GIOHANGDAO.UpdateItem(makh, masp, -1, true))
                    LoadGH(makh);
                else
                {
                    Label1.Text = "<h1>Lỗi không thể giảm sản phẩm</h1>";
                    Label1.Visible = true;
                }
            }
        }

        protected void clear_all_Click(object sender, EventArgs e)
        {
            int makh = Convert.ToInt32(Session["LoginID" + Session.SessionID]);
            if (GIOHANGDAO.DeleteAllItem(makh))
                LoadGH(makh);
            else
            {
                Label1.Text = "<h1>Lỗi không thể xoá sản phẩm</h1>";
                Label1.Visible = true;
            }
        }
    }
}