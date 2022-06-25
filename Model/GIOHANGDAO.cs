using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoanWebNhomPV.Model
{
    public class GIOHANGDAO
    {
        static string connect = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\DatabaseWeb.mdf; Integrated Security = True";

        public static DataTable getItem(int makh)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_GH_getItem";
                    cm.Parameters.AddWithValue("@makh", makh);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    da.Fill(ds);
                }
                con.Close();
            }
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return new DataTable();
        }
        public static bool AddItem(int makh, int masp)
        {
            int record = 0;
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_GH_AddNewItem";
                    cm.Parameters.AddWithValue("@makh", makh);
                    cm.Parameters.AddWithValue("@masp", masp);
                    record = cm.ExecuteNonQuery();
                }
                con.Close();
            }
            return record > 0;
        }
        public static bool UpdateItem(int makh, int masp, int sl, bool? type) /*type: false:sl=@sl, true:sl+=@sl*/
        {
            int record = 0;
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_GH_UpdateItem";
                    cm.Parameters.AddWithValue("@makh", makh);
                    cm.Parameters.AddWithValue("@masp", masp);
                    cm.Parameters.AddWithValue("@sl", sl);
                    cm.Parameters.AddWithValue("@type", type);
                    record = cm.ExecuteNonQuery();
                }
                con.Close();
            }
            return record > 0;
        }

        internal static bool DeleteAllItem(int makh)
        {
            int record = 0;
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_GH_deleteAll";
                    cm.Parameters.AddWithValue("@makh", makh);
                    record = cm.ExecuteNonQuery();
                }
                con.Close();
            }
            return record > 0;
        }
    }
}