using DoanWebNhomPV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoanWebNhomPV
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        string connect = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\DatabaseWeb.mdf; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            DataTable dt = SANPHAMDAO.Category();
            List.DataSource = dt;
            List.DataBind();
        }

        protected void List_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            this.bind();
        }
    }
}