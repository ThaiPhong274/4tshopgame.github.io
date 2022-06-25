using DoanWebNhomPV.Model;
using System;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace DoanWebNhomPV
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategory();
                BindProduct(1);
                Panel panel = DataList1.Items[0].FindControl("Panel1") as Panel;
                panel.CssClass = "category background_selected";
                Label label = (Label)DataList1.Items[0].FindControl("Label1");
                Label2.Text = label.Text;
            }
        }
        /*Load sản phẩm theo: id: danh mục, PageIndex: số trang*/
        private void BindProduct(int Id) 
        {
            DataTable dt = SANPHAMDAO.getProductsByCategory(Id);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }
        /*Load danh mục*/
        private void BindCategory() 
        {
            DataTable dt = SANPHAMDAO.Category();
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
        /*Sự kiện click danh mục*/
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string CgId = e.CommandArgument.ToString();
            int index = e.Item.ItemIndex;
            for (int i = 0; i < DataList1.Items.Count; i++)
            {
                Panel panel = DataList1.Items[i].FindControl("Panel1") as Panel;
                if (panel != null)
                {
                    panel.CssClass = index == i ? "category background_selected" : "category";
                }
            }
            DataPager1.SetPageProperties(0, DataPager1.PageSize, false);
            BindProduct(Int32.Parse(CgId));
            Label label = (Label) e.Item.FindControl("Label1");
            Label2.Text = label.Text;
            HiddenField1.Value = CgId;
            
        }
        /*Sự click nút phân trang*/
        private void Page_Command(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(((Button)sender).CommandArgument);   
            int category = Convert.ToInt32(HiddenField1.Value);
            BindProduct(category);
        }
        protected void List_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            int category = Convert.ToInt32(HiddenField1.Value);
            this.BindProduct(category);
        }
    }
}