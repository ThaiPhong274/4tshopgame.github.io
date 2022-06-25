using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoanWebNhomPV.Model
{ 
    public class SANPHAMDAO
    {
        static string connect = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\DatabaseWeb.mdf; Integrated Security = True";
        /*Lấy tất cả danh mục*/
        public static DataTable Category()
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_Product_getCategory";
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    da.Fill(ds);
                }
                con.Close();
            }
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return new DataTable();
        }

        public static DataTable getInforProduct(int id)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_Product_getInforProduct";
                    cm.Parameters.AddWithValue("@masp", id);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    da.Fill(ds);
                }
                con.Close();
            }
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return new DataTable();
        }

        /*Lấy sản phẩm theo id danh mục*/
        public static DataTable getProductsByCategory(int CgId)
        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_Product_getProductByCategory";
                    cm.Parameters.AddWithValue("@CgId", CgId);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    da.Fill(dt);
                }
                con.Close();
            }
            return dt;
        }
    }
}