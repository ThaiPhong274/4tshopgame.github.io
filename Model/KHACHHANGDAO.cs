using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoanWebNhomPV.Model
{
    public class KHACHHANGDAO
    {
        static string connect = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\DatabaseWeb.mdf; Integrated Security = True";

        public static KHACHHANG Login(string username, string password)
        {
            KHACHHANG kh = new KHACHHANG();
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_KH_Login";
                    cm.Parameters.AddWithValue("@Username", username);
                    cm.Parameters.AddWithValue("@Password", password);
                    SqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())//duyệt từng dòng
                    {
                        for (int i = 0; i < dr.FieldCount; i++)//duyệt từng cột
                        {
                            var colName = dr.GetName(i);
                            var value = dr.GetValue(i);
                            var property = kh.GetType().GetProperty(colName);
                            if (property != null && value != DBNull.Value)
                            {
                                property.SetValue(kh, value);
                            }
                        }
                    }
                }
                con.Close();
            }
            return kh;
        }

        public static bool CreateNewKH(string email, string password,string hoten)
        {
            int Record = 0;
            using (var con = new SqlConnection(connect))
            {
                con.Open();
                using (var cm = con.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "sp_KH_CreateNewKH";
                    cm.Parameters.AddWithValue("@Email", email);
                    cm.Parameters.AddWithValue("@Password", password);
                    cm.Parameters.AddWithValue("@Hoten", hoten);
                    Record = cm.ExecuteNonQuery();
                }
                con.Close();
            } 
            return Record > 0;
        }
    }
}