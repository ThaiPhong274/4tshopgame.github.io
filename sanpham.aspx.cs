using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoanWebNhomPV
{
    public partial class sanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string request = Request.QueryString["product"];
            if (!String.IsNullOrEmpty(request))
            {
                BindProduct(request);
            }
        }

        private void BindProduct(string request)
        {
            int id = Convert.ToInt32(request);
            DataTable sanpham = SANPHAMDAO.getInforProduct(id);
            DataList1.DataSource = sanpham;
            DataList1.DataBind();
        }
    }
}